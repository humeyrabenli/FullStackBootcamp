import Navigation from './components/Navigation';
import Authors from './components/Authors';
import Books from './components/Books';
import { Component } from 'react';

export default class App extends Component{
   state={
    currentAuthor:""
   }
  selectAuthor=(author) =>{
    this.setState({currentAuthor:author.authorName});
  }
  render() {

  
  return (
    <div className="container">
      <div className="row">
      <Navigation/>
      </div>
      <div className="row">
        <div className="col-3">
        <Authors/>
        </div>

        <div className="col-9">
        <Books/>
        </div>
      </div>
      
      

     
      

    </div>
  );
}
}

