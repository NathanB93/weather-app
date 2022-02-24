﻿const ForecastTable = (props) => {
   
    const formatDate = (date) => {
        let dateISO = new Date(date)
        return dateISO.toLocaleDateString('en-GB')
    }
        
    return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Date</th>
                        <th>Temp. (C)</th>
                        <th>Temp. (F)</th>
                        <th>Summary</th>
                    </tr>
                </thead>
                <tbody>
                    {props.forecasts.map(forecast =>
                        <tr key={forecast.Date}>
                            <td>{formatDate(forecast.Date)}</td>
                            <td>{forecast.Day.maxtemp_c}</td>
                            <td>{forecast.Day.mintemp_f}</td>
                            <td>{forecast.Day.condition.text}</td>
                        </tr>
                    )}
                </tbody>
            </table>

        );
   
};
export default ForecastTable;