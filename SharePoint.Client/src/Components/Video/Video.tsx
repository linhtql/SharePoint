import React from "react";
import Image from "../../Base/Image";
import "./index.scss";
import { dataVideo, styleVideo } from "../../helper/const";

import { GoPlay } from "react-icons/go";
class Video extends React.Component {
  render() {
    return (
      <div className="wrapper__content">
        <div className="title">
          <h2 className="title__text">Video Gallery</h2>
        </div>
        <div className="grid__container">
          {dataVideo.map((item) => {
            return (
              <div className="grid__container--item" key={item.id}>
                <img src={item.img} alt={item.title} />
                <div className="grid__container--item--icon">
                  <GoPlay style={styleVideo} />
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

export default Video;
