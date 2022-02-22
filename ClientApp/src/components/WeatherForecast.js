import React, { Component, useEffect } from 'react';
import ForecastTable from './ForecastTable'
import authService from './api-authorization/AuthorizeService'
import { useState } from 'react'


const WeatherForecast= () => {
    const [forecasts, setForecasts] = useState([]);
    const [location, setLocation] = useState("");
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
        }).then(resp => resp.json()).then((data) => {
            setForecasts(data)
        }).catch((error) => console.log(error));

    }

    return (
        <div>

            <h1> Weather Forecast:</h1>
            <label>

                Location:
                <input type="text" value={location} onChange={(e) => { setLocation(e.target.value) }} />
            </label>
            <input type="button" value="Search" onClick={handleClick} />
            <p>Forecast for the next 5 days in {location}:</p>
            {<ForecastTable forecasts={forecasts} />}

        </div>
    );
};

export default WeatherForecast




//export class FetchData extends Component {
 // static displayName = FetchData.name;

  //constructor(props) {
    //super(props);
    //  this.state = {
    //      forecasts: [], loading: true, location: "Edinburgh", token: {}
    //  };
    //  this.handleChange = this.handleChange.bind(this);
    //  this.handleClick = this.handleClick.bind(this);
      
      
      
  //}

  //componentDidMount() {
    //this.populateWeatherData();
     
      
      

 // }

  //static renderForecastsTable(forecasts) {
    //return (
      //<table className='table table-striped' aria-labelledby="tabelLabel">
        //<thead>
          //<tr>
            //<th>Date</th>
     //       <th>Temp. (C)</th>
       //     <th>Temp. (F)</th>
         //   <th>Summary</th>
         // </tr>
        //</thead>
        //<tbody>
 //         {forecasts.map(forecast =>
   //         <tr key={forecast.date}>
     //         <td>{forecast.maxtemp_c}</td>
     //         <td>{forecast.maxtemp_f}</td>
     //         <td>{forecast.mintemp_c}</td>
     //         <td>{forecast.mintemp_f}</td>
     //       </tr>
     //     )}
     //   </tbody>
     // </table>
  //  );
 // }

 //   render() {
//
//        const forecasts = this.state.forecasts;
//        //let contents = this.state.loading ? <p><em>Loading...</em></p>
//          // : FetchData.renderForecastsTable(forecasts)
//        const renderForecastTable = () => {
//          //  if (forecasts.length > 0) {
//                return <ForecastTable forecasts={forecasts}/>
//        };
//        

  //  return (
  //      <div>
            
  //         <label>
                    
   //         Location:
     //       <input type="text" value={this.state.location} onChange={this.handleChange} />
       //     </label>
         //   <input type="button" value="Search" onClick={this.handleClick}/>
            
     //   <h1 id="tabelLabel" >Weather forecast</h1>
       //     <p>This component demonstrates fetching data from the server.</p>
         //   {renderForecastTable }
            
   //     </div>
  //  );
  //  }

  //  handleChange(e) {
   //     this.setState({ location: e.target.value });
   // }
   // handleClick(e) {
   //     e.preventDefault();
        
        
   //     fetch('weatherforecast/' + this.state.location, {
    //        headers: !this.state.token ? {} : { 'Authorization': `Bearer ${this.state.token}` }
    //    }).then(data => {

   //         this.setState({ forecasts: data })
   //     });
        
  //  }
 // async populateWeatherData() {
    
   //   const token = await authService.getAccessToken();
     // this.setState({ token: token });
      
      //const response = await fetch('weatherforecast/' + this.state.location, {
        //headers: !token ? {} : { 'Authorization': `Bearer ${token}` }
    //});
    //const data = await response.json();
    //this.setState({ forecasts: data, loading: false });
    
  //  }
   
//}