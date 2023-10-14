import React, { Component, Fragment } from "react";
import { dataHow } from "../../helper/const";
import "./index.scss";
import Image from "../../Base/Image";
import { typeDataHow } from "../../helper/type";

interface State {
  collapse: typeDataHow;
}
export default class How extends Component {
  state: State = {
    collapse: {},
  };

  handleCollapse = (item: typeDataHow) => {
    this.setState({
      collapse: item.id === this.state.collapse.id ? {} : { ...item },
    });
  };

  render() {
    return (
      <div className="wrapper__content">
        <div className="title">
          <h2 className="title__text">How Do I</h2>
        </div>
        <div className="how__container">
          <div className="how__search">
            <div className="how__search--img">
              <img src={Image.search} alt="search" />
            </div>
            <p className="how__search--text">Find Questions</p>
          </div>
          {dataHow.map((item) => {
            return (
              <Fragment key={item.id}>
                <div
                  className={`how__question ${
                    this.state.collapse.id && this.state.collapse.id === item.id
                      ? "green"
                      : ""
                  }`}
                  onClick={() => this.handleCollapse(item)}
                >
                  <div className="how__question--img">
                    <img
                      src={
                        this.state.collapse.id === item.id
                          ? Image.expand
                          : Image.collapse
                      }
                      alt="sear"
                    />
                  </div>
                  <p className="how__question--text">{item.title}</p>
                </div>
                {Object.keys(this.state.collapse).length !== 0 &&
                this.state.collapse.id === item.id ? (
                  <div className="how__answer">
                    <p className="how__question--text">A:</p>
                    <p className="how__question--text">{item.content}</p>
                  </div>
                ) : null}
              </Fragment>
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
