﻿using MvvmHelpers.Commands;
using SightsNavigator.Models;

using Microsoft.Maui.Controls.Maps;
using System.Diagnostics;

using SightsNavigator.Services;
using SightsNavigator.Services.GooglePlaceService;

namespace SightsNavigator.ViewModels
{

    class DetailedPageSightViewModel : CommunityToolkit.Mvvm.ComponentModel.ObservableObject
    {


        private readonly City.Sight sight;
        private City city;

        private IGooglePlaceService _googleservices;
        public IGooglePlaceService Googleservices { get => _googleservices; set => _googleservices = value; } //=> DependencyService.Get<IGooglePlaceService>();
        public IServiceProvider ServiceProvider { get; set; }

        public DetailedPageSightViewModel(City city, City.Sight sight)
        {
            //this._googleservices = ServiceProvider.GetService<IGooglePlaceService>();
            this.city = city;
            this.sight = sight;
            PageAppearingCommand = new AsyncCommand(PageAppearing);
            _dName = sight.Name;
            _dxid = sight.Xid;
            _daddress = sight.SightAddress.FullAddress;
            _dimage = sight.Image;
            _ddescription = sight.Description;
            _dlat = sight.Lat;
            _dlon = sight.Lon;
            try
            {
                DLocation = new Location(_dlat, _dlon);
            }
            catch (Exception ex)
            {
                Debugger.Log(0, "Error", ex.ToString());
            }
            WhatIsVisible();
            AddRemoveFavouriteCommand = new AsyncCommand(onAddRemovePressed);

            if (TripListModel.CityExists(city))
            {
                var favourites = city.FavouriteSights;
                if (favourites.Any(s => s.Xid == sight.Xid))
                {
                    _wasAddedToTripList = true;
                    ChangeFavouriteButtonState();
                    OnPropertyChanged(nameof(ImageState));
                }
            }
        }




        // COMMANDS - start
        public AsyncCommand PageAppearingCommand { get; set; }
        public AsyncCommand AddRemoveFavouriteCommand { get; set; }
        // COMMANDS - end



        public String DName { get => _dName; set => _dName = value; }
        private string _dName;
        public bool HasName { get => _hasname; set => _hasname = value; }
        private bool _hasname;

        public String DXid { get => _dxid; set => _dxid = value; }
        private string _dxid;

        public String DAddress { get => _daddress; set => _daddress = value; }
        private string _daddress;
        public bool HasAddress { get => _hasaddress; set => _hasaddress = value; }
        private bool _hasaddress;

        public String DImage { get => _dimage; set => _dimage = value; }
        private string _dimage;

        public String DDescription { get => _ddescription; set => _ddescription = value; }
        private string _ddescription;

        public double DLat { get => _dlat; set => _dlat = value; }
        public double DLon { get => _dlon; set => _dlon = value; }
        private double _dlat;
        private double _dlon;

        public string ImageState { get => _imagestate; set => _imagestate = value; }
        private string _imagestate = "heart_empty.png";

        private bool _wasAddedToTripList = false;

        public Location DLocation { get; set; }
        private void WhatIsVisible()
        {
            if (!String.IsNullOrEmpty(sight.Name))
            {
                HasName = true;
            }
            else
            {
                HasName = false;
            }
            HasAddress = !HasName;
        }

        private async Task onAddRemovePressed()
        {
            try
            {
                //throw new ArgumentException();
                _wasAddedToTripList = !_wasAddedToTripList;
                if (TripListModel.CityExists(city))
                {
                    var favourites = city.FavouriteSights;
                    if (_wasAddedToTripList)
                    {
                        //add a new sight to the list
                        Add(ref favourites);
                    }
                    else
                    {
                        //remove a new sight from the list
                        Remove(ref favourites);
                    }
                    city.FavouriteSights = favourites;
                    TripListModel.updateCityProporties(city);
                }
                else
                {
                    var google = new GooglePlace(city);
                    if(google == null)
                    {
                        await Application.Current.MainPage.DisplayAlert("Error", new ArgumentNullException(nameof(google)).ToString(), "OK");
                    }
                    google = await _googleservices.getDataFromGoogle(google);                   
                    if(google.GooglePlaceCityId == "ERROR_ID")
                    {
                        await Application.Current.MainPage.DisplayAlert("Error", $"Sorry, seems a city or town you are trying to add contains spelling mistakes, or it is not a city at all.\nPlease, be sure you are adding a correct city or try attempt later.", "OK");
                        return;
                    }
                    city.Backgrounds = google.GooglePlacePhotoCandidates;
                    city.FavouriteSights.Insert(0, sight);
                    TripListModel.AddTrip(city);
                }
                ChangeFavouriteButtonState();
            }
            catch (Exception ex)
            {
                 await Application.Current.MainPage.DisplayAlert("Error", $"{ex.Message} {Environment.NewLine} {ex.StackTrace}", "OK");
            }
        }


        private void Add(ref List<City.Sight> favourites)
        {
            if (!favourites.Any(s => s.Xid == sight.Xid))
            {
                //if it doesn't conatin in the favourites list
                favourites.Insert(0, sight);
            }
        }

        private void Remove(ref List<City.Sight> favourites)
        {
            if (favourites.Any(s => s.Xid == sight.Xid))
            {
                //if it conatins in the favourites list just remove it
                favourites.RemoveAll(s => s.Xid.Equals(sight.Xid));
            }
        }




        private void ChangeFavouriteButtonState()
        {
            if (_wasAddedToTripList)
            {
                ImageState = "heart_filled.png";
            }
            else
            {
                ImageState = "heart_empty.png";
            }
            OnPropertyChanged(nameof(ImageState));
        }


        private async Task PageAppearing()
        {
            await Refresh();
        }

        public async Task Refresh()
        {
            var b = 3;
        }
    }
}
