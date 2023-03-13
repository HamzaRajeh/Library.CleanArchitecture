import React, { Component } from 'react';
import { Book } from './Book';

export class FetchData extends Component {
  static displayName = FetchData.name;

  constructor(props) {
    
let isAthuntication = document.cookie;
if (isAthuntication==false){
  window.location.href="/Login";
}  else{

    super(props);
    this.state = { DataBooks: [], loading: true };}
  }

  componentDidMount() {
let isAthuntication = document.cookie;
if (isAthuntication==false){
  window.location.href="/Login";
}   else{

  this.populateWeatherData();

}
  }

  static renderForecastsTable(DataBooks) {
    return (


      <>
      <Book  />
      <br/>
      <table className="table table-striped" aria-labelledby="tableLabel">
        <thead>
          <tr>
            <th>Id</th>
            <th>Book Name</th>
            <th>CategoryID</th>
            <th>AuthorID</th>
            <th>image</th>
          </tr>
        </thead>
        <tbody>
          {DataBooks.map(data =>
            <tr key={data.id}>
              <td>{data.id}</td>
              <td>{data.bookDiscriptsion}</td>
              <td>{data.categoryId}</td>
              <td>{data.authorId}</td>
              <td><img src={"data:image/png;base64,"+data.booksImg} style={{width:"50px",height:"20px"}}/></td>
            </tr>
          )}
        </tbody>
      </table>
    </>);
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : FetchData.renderForecastsTable(this.state.DataBooks);

    return (
      <div>
        <h1 id="tableLabel">Library's Books</h1>
         {contents}
      </div>
    );
  }

  async populateWeatherData() {
    const response = await fetch('/api/Books');
    const data = await response.json();
    this.setState({ DataBooks: data, loading: false });
  }


    
}
