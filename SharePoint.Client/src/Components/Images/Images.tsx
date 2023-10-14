import React from "react";
import Image from "../../Base/Image";
import "./index.scss";
import { dataImg } from "../../helper/const";

class Images extends React.Component {
  render() {
    return (
      <div className="wrapper__content">
        <div className="title">
          <h2 className="title__text">Image Gallery</h2>
        </div>
        <div className="grid__container">
          {dataImg.map((item) => {
            return (
              <div className="grid__container--item" key={item.id}>
                <img src={item.img} alt={item.title} />
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

export default Images;
