import MainPageHeading from "../../components/MainPageHeading/MainPageHeading";
import styles from "./MainPage.module.scss";

const MainPage = () => {
  return (
    <main>
      <div className={styles.title}>Project name timeline</div>
      <div className={styles.header}>
        <MainPageHeading name={"Developers"} color={"#E3005F"} />
        <MainPageHeading name={"Client/Testers"} color={"#0471A6"} />
      </div>
    </main>
  );
};

export default MainPage;
