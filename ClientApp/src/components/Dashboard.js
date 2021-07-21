import React, { Component } from 'react';

export class Dashboard extends Component {
    static displayName = Dashboard.name;

    constructor(props) {
        super(props);
        this.state = { teams: [], loading: true };
    }

    componentDidMount() {
        this.populateData();
    }

    static renderTable(teams) {
        return (
            <table className='table table-striped' aria-labelledby="dashboard">
                <thead>
                    <tr>
                        <th>Team / player name</th>
                        <th>Games played</th>
                        <th>Wins</th>
                        <th>Losses</th>
                        <th>Win ratio</th>
                        <th>Goals for</th>
                        <th>Goals against</th>
                        <th>Goals difference</th>
                    </tr>
                </thead>
                <tbody>
                    {teams.map(team =>
                        <tr key={team.teamID}>
                            <td>{team.name}</td>
                            <td>{team.wins + team.losses}</td>
                            <td>{team.wins}</td>
                            <td>{team.losses}</td>
                            <td>{team.wins + team.losses !== 0 ? team.wins / (team.wins + team.losses) : "N/A"}</td>
                            <td>{team.goalsFor}</td>
                            <td>{team.goalsAgainst}</td>
                            <td>{team.goalsFor - team.goalsAgainst}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Dashboard.renderTable(this.state.teams);

        return (
            <div>
                <h1 id="dashboard" >Dashboard</h1>
                <div className="d-grid gap-2 d-md-flex justify-content-md-end mb-2">
                    <button className="btn btn-primary me-md-2" type="button">Button</button>
                    <button type="button" className="btn btn-secondary ml-1">Add team</button>
                </div>                
                {contents}
            </div>
        );
    }

    async populateData() {
        const response = await fetch('api/teams');
        const data = await response.json();
        this.setState({ teams: data, loading: false });
    }
}
