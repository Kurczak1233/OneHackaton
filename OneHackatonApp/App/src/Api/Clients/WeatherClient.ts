import application from "../../appConfig.json";
import { AxiosClient } from "../AxiosClient/AxiosClient";

const base = application.baseUrl;
const Posts = "Posts";

const getWeatherForecast = async (): Promise<any> => {
  return AxiosClient("GET", `${Posts}`, base);
};

export { getWeatherForecast };
