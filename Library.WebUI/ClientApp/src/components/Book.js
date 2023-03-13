import React,{Component} from "react";
import './styles/Book.css';


export   class Book extends Component{
 
  constructor(props) {
    super(props);
    this.state = { imgd:""  };
  }
 
    render(){

        return (

            <>
            <div className="container">
   <div className="row">
    <div className="col-25">
      <label htmlFor="BookDiscriptsion">Book Titel</label>
    </div>
    <div className="col-75">
      <input type="text" id="BookDiscriptsion" name="BookDiscriptsion" placeholder="Book Titel.." />
    </div>
  </div>
  
  <div className="row">
    <div className="col-25">
      <label htmlFor="CategoryID">Category</label>
    </div>
    <div className="col-75">
      <select id="CategoryID" name="CategoryID"  >
        <option value="1">Finance</option>
        <option value="2">Technology</option>
       </select>
    </div>
    
  </div>

  <div className="row">
    <div className="col-25">
      <label htmlFor="AuthorID">Author</label>
    </div>
    <div className="col-75">
      <select id="AuthorID" name="AuthorID"  >
        <option value="1">Hamza Rajeh</option>
         
      </select>
    </div>
    
  </div>

  <div className="row">
    <div className="col-25">
      <label htmlFor="Books_IMG">Book's IMG</label>
    </div>
    <div className="col-75">
      <input type="file" id="Books_IMG" accept="image/png" name="Books_IMG" placeholder="Book's IMG.." onChange={(event)=>{


 var image = document.getElementById('output');
  image.src=URL.createObjectURL(event.target.files[0]);
 this.convertBase64(event.target.files[0]).then(res=>{
  console.log(res)
  this.setState({imgd:res})
 }).error(err=>{
  console.log(err);
 })

      }}/>
       <p><img id="output" width="200"/></p>
    </div>
  </div>
  
  <br/>

   <div className="row">
    <button  className="submit" onClick={()=>{

var bodyD = JSON.stringify({
    BookDiscriptsion:document.getElementById("BookDiscriptsion").value,
  CategoryID:document.getElementById("CategoryID").value,
  AuthorID:document.getElementById("AuthorID").value,
  booksImg:this.state.imgd.split("data:image/png;base64,")[1]
  } );


fetch('/api/Books', {
  method: 'POST',
  headers: {
      'Accept': 'application/json, text/plain, */*',
      'Content-Type': 'application/json'
  },
  body:bodyD
})
.then(function (response) {
  return response.json();
})
.then(function (result) {
  alert("seccess..");
  setTimeout(()=>{},1000)
  window.location.href="/fetch-data"
})
.catch (function (error) {
  console.log('Request failed', error);
});
this.state.proprties.recall(); 


    }}>Add</button>
  </div>
</div>
            
</>
        );
    }
    convertBase64 = (file) => {
      return new Promise((resolve, reject) => {
          const fileReader = new FileReader();
          fileReader.readAsDataURL(file);
  
          fileReader.onload = () => {
              resolve(fileReader.result);
          };
  
          fileReader.onerror = (error) => {
              reject(error);
          };
      });
  };
  
  


    
  }
