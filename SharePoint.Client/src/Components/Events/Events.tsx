import React, { Component } from "react";
import "./index.scss";
import { dataEvents } from "../../helper/const";
import Image from "../../Base/Image";
export default class Events extends Component {
  render() {
    return (
      <div className="wrapper__content">
        <div className="title">
          <h2 className="title__text">Events</h2>
        </div>
        <div className="events__wrapper">
          {dataEvents.map((item) => {
            return (
              <div className="events__container" key={item.id}>
                <div className="events__item--time">
                  <p className="events__item--time--date">{item.day}</p>
                  <span className="events__item--time--month">Jan</span>
                </div>
                <div className="events__item--main">
                  <h4 className="events__item--main--title">{item.title}</h4>
                  <div className="events__time">
                    <img
                      src={Image.clock}
                      alt="view"
                      className="events__time--img"
                    />
                    <p className="events__time--text">{item.time}</p>
                  </div>
                </div>
              </div>
            );
          })}
        </div>
        <div className="view__more">
          <span className="view__more--text">View More</span>
          <img src={Image.arrow} alt="view" className="view__more--img" />
        </div>
      </div>
    );
  }
}
