import React, { Component } from "react";
import { dataQuick } from "../../helper/const";
import "./index.scss";
import Image from "../../Base/Image";

export default class Quick extends Component {
  render() {
    return (
      <div className="wrapper__content">
        <div className="title">
          <h2 className="title__text">Quick link</h2>
        </div>
        <div className="quick__container">
          {dataQuick.map((item) => {
            return (
              <div className="quick__container--item quick" key={item.id}>
                <div className="quick__box">
                  <img
                    className="quick__box--img"
                    src={item.img}
                    alt={item.title}
                    style={{ width: item.width, height: item.height }}
                  />
                  <p className="quick__box--text">{item.title}</p>
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
