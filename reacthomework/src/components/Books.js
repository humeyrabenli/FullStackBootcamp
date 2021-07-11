import React, { Component } from 'react'

export default class Books extends Component {
    state={
        books:[
               {bookId:1, authorId:1,bookName:"Cehennem",url:"https://i.dr.com.tr/cache/600x600-0/originals/0000000442778-1.jpg"},
               {bookId:2, authorId:1,bookName:"Başlangıç",url:"https://i.dr.com.tr/cache/600x600-0/originals/0001720220001-1.jpg"},
               {bookId:3, authorId:2,bookName:"İtiraflarım",url:"https://i.dr.com.tr/cache/600x600-0/originals/0001705096001-1.jpg"},
               {bookId:4, authorId:3,bookName:"Suç ve Ceza",url:"https://i.dr.com.tr/cache/600x600-0/originals/0001698562001-1.jpg"},
        ]
}
    render() {
        return (
            <div className="row">
                
                <h3>Kitaplar</h3>
                {this.state.books.map(book=>(
                <div className="col-lg-4">  
                <div className="card mb-3 shadow-sm" style={{width:"16rem"}}>
                    <img className="card-img-top" src={book.url} alt="Card image Cap"/>
                    <div className="card-body">
                    <h5 class="card-title">{book.bookName}</h5>
                    </div>
                </div>
                </div> 
                ))}
            </div>
        )
    }
}
