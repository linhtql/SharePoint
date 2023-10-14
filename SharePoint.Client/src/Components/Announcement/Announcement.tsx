import React from "react";
import Image from "../../Base/Image";
import "./index.scss";
import { dataAnnouncement } from "../../helper/const";
class Announcement extends React.Component {
  render() {
    return (
      <div className="wrapper__content">
        <div className="title">
          <h2 className="title__text">Announcement</h2>
        </div>

        <div>
          {dataAnnouncement.map((item) => {
            return (
              <div className="content" key={item.id}>
                <div className="content__pic">
                  <img
                    src={item.img}
                    alt="Avatar"
                    className="content__pic--img"
                  />
                </div>
                <div className="content__text">
                  <h4 className="content__text--title">{item.title}</h4>
                  <p className="content__text--subtitle">{item.subTitle}</p>
                  <div className="content__text--wrapper">
                    <div className="content__text--wrapper--date">
                      <img src={Image.date} alt="date" />
                      <p>{item.date}</p>
                    </div>
                    <div className="content__text--wrapper--button">
                      <p>{item.titleBtn}</p>
                    </div>
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

export default Announcement;
