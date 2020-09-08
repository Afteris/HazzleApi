import React, { Component } from 'react';
import { Link } from 'react-router-dom';

export class Statistics extends Component {
    static displayName = Statistics.name;

    constructor(props) {
        super(props);
        this.state = { statistics: [], loading: true };
        
    }

    componentDidMount() {
        this.populateStatisticsData();
    }
    static getShortDate(datetime) {
        return new Date(datetime).toISOString().slice(0, 10);
    }
    static renderStatistics(statistics) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>px</th>
                        <th>Path</th>
                        <th>Title</th>
                        <th>Score</th>
                        <th>Published</th>
                    </tr>
                </thead>
                <tbody>
                    {statistics.map(statistic =>
                        <tr key={statistic.id}>
                            <td>{statistic.id}</td>
                            <td><Link to={'statistics' + statistic.path + '/' + statistic.id}>{statistic.path + '/' + statistic.id}</Link></td>
                            <td>{statistic.title}</td>
                            <td>{statistic.score}</td>
                            <td>{this.getShortDate( statistic.published )}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {   
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Statistics.renderStatistics(this.state.statistics);

        return (
            <div>
                <h1 id="tabelLabel">Statistics</h1>
                {contents}
            </div>
        );
    }

    async populateStatisticsData() {
        const response = await fetch('statistics');
        const data = await response.json();
        this.setState({ statistics: data, loading: false });
    }
    
}
