import React, { Component } from "react";

export default class Authors extends Component {

    state={
        authors:[
            {authorId:1, authorName:"Dan Brown"},
            {authorId:2, authorName:"Dostoyevski"},
            {authorId:3, authorName:"Tolstoy"}
        ]

        
    }

    
  render() {
    return (
      <div>
        <h2>Yazarlar</h2>
        <ul class="list-group">
            {this.state.authors.map(author=>(
              <li class="list-group-item" key={author.authorId}>{author.authorName}</li>
            ))}
          
         
        </ul>
      </div>
    );
  }
}
