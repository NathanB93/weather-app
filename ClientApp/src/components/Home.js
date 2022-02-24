import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div>
            <h1>Welcome to Weather App!</h1>
            <p> Login to use our forecasting service. If you don't have an account please register to get started!</p>
        
          
      </div>
    );
  }
}
