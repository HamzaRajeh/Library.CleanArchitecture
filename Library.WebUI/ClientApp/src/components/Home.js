import React, { Component } from 'react';
import CBook from '../components/Library/CardBook'
 import './styles/card.css';
export class Home extends Component{

  
  constructor(props) {
    
let isAthuntication = document.cookie;
if (isAthuntication==false){
  window.location.href="/Login";
}  else{
    super(props);
    this.state = { Books: [] ,loading: true };
  }}
  static displayName = Home.name;
  
  componentDidMount() {
    this.populateWeatherData();
  }
  async populateWeatherData() {
    const response = await fetch('api/Books');
    const data = await response.json();
    this.setState({ Books: data, loading: false });
  }
  render() {
    return (
      <>    
         <div class="container-card">
        {this.state.Books.map(Book=>{
          return(
           <CBook  id={Book.id}   Titel={Book.bookDiscriptsion}   />)  
        })}
    
         </div>
         </>
    );
  }
}
