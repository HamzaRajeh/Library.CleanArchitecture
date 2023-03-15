import React, { Component  } from 'react';
import CBook from '../components/Library/CardBook'
 import './styles/card.css';
export class Home extends Component{

  
  constructor(props) {
    
 
    super(props);
    this.state = { Books: [] ,loading: true ,OragnalData:[]};
  }
  static displayName = Home.name;
  
  componentDidMount() {
    this.populateData();
  }
  async populateData() {
    const response = await fetch('api/Books');
    const data = await response.json();
    this.setState({ Books: data, loading: false ,OragnalData:data});
  }



  render() {
    return (
      <>    
      <div style={{
  display:'flex',justifyContent:'center'
}}>
        <input  style={{maxWidth:'50rem'}} type='text' placeholder='Search'  onChange={(data)=>{
        
       let result= this.state.OragnalData;
        this.setState({Books:data.currentTarget.value?result.filter(a=>a.bookDiscriptsion===data.currentTarget.value):result});      
      }
        }/>
      </div>
         <div class="container-card">
        {this.state.Books.map(Book=>{
          return(
           <CBook  id={Book.id}   Titel={Book.bookDiscriptsion} />)  
        })}
    
         </div>
         </>
    );
  }
}
