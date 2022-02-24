import React, { Component, useEffect } from 'react';
import ForecastTable from './ForecastTable'
import authService from './api-authorization/AuthorizeService'
import { useState } from 'react'

/**
 * WeatherForecast class component allows user to view a weather forecast
 * for a given location.
 * . 
 * */
const WeatherForecast = () => {
    /** An array of daily forecasts. */
    const [forecasts, setForecasts] = useState([]);
    /** The location of a weather forecast(city) */
    const [location, setLocation] = useState("");
    /** Authentication token*/
    const [token, setToken] = useState("")

    useEffect(() => {
        if (!token) {
            getToken()
        }

    }, []);

    const getToken = async () => {
        const token = await authService.getAccessToken();
        setToken(token);
    };

    const handleClick = (e) => {
        e.preventDefault()
        fetch('weatherforecast/' + location, {
            headers: !token ? {} : { 'Authorization': `Bearer ${token}` }
        })
            .then((resp) => {
                if (resp.status !== 200) {
                    alert("Please enter a valid location, and try again.")
                    return;
                } resp.json().then((data) => {
                    setForecasts(data);
                });

            });
    }
  
    return (
        <div>

            <h1> Weather Forecast:</h1>

            <label>
                <p>Enter a city name below to see a 3 day forecast:</p>
                Location:
                <input type="text" value={location} onChange={(e) => { setLocation(e.target.value) }} />
            </label>
            <input type="button" value="Search" onClick={handleClick} />
            <p>Forecast for the next 3 days in {location}:</p>
            {<ForecastTable forecasts={forecasts} />}

        </div>
    );
};

export default WeatherForecast