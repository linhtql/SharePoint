import React, { Component } from "react";
import Image from "../../Base/Image";
import { dataDocument } from "../../helper/const";
import "./index.scss";
import { typeDataDocument } from "../../helper/type";

class Document extends Component {
  render() {
    return (
      <div className="wrapper__content">
        <div className="title">
          <h2 className="title__text">Document Gallery</h2>
        </div>

        <div className="document__container">
          {Array.isArray(dataDocument) &&
            dataDocument.map((item: typeDataDocument) => {
              return (
                <div
                  key={item.id}
                  className="document__container--item document"
                >
                  <div className="document__text">
                    <h6>{item.title}</h6>
                  </div>

                  {item.data.map((data) => {
                    return (
                      <div key={data.id} className="document__content">
                        <img
                          src={data.img}
                          alt={data.titleImg}
                          className="document__content--img"
                        />
                        <p className="document__content--text">
                          {data.subTitle}
                        </p>
                      </div>
                    );
                  })}

                  <div className="view__more">
                    <span className="view__more--text">View More</span>
                    <img
                      src={Image.arrow}
                      alt="view"
                      className="view__more--img"
                    />
                  </div>

                  {item.children && (
                    <div className="document__container--item--children">
                      <div className="document__text">
                        <h6>{item.titleChildren}</h6>
                      </div>
                      {item.children.map((data) => {
                        return (
                          <div key={data.id} className="document__content">
                            <img
                              src={data.img}
                              alt={data.titleImg}
                              className="document__content--img"
                            />
                            <p className="document__content--text">
                              {data.subTitle}
                            </p>
                          </div>
                        );
                      })}
                      <div className="view__more">
                        <span className="view__more--text">View More</span>
                        <img
                          src={Image.arrow}
                          alt="view"
                          className="view__more--img"
                        />
                      </div>
                    </div>
                  )}
                </div>
              );
            })}
        </div>
      </div>
    );
  }
}

export default Document;
