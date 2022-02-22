const ForecastTable = (props) => {
    //if (props.forecasts.length > 0) {
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
                        <tr key={forecast.date}>
                            <td>{formatDate(forecast.date)}</td>
                            <td>{forecast.day.maxtemp_c}</td>
                            <td>{forecast.day.mintemp_f}</td>
                            <td>{forecast.day.condition.text}</td>
                        </tr>
                    )}
                </tbody>
            </table>

        );
    //}
};
export default ForecastTable;