import { Link } from "react-router-dom";
import styles from "./MainPageHeading.module.scss";

interface IMainPageHeading {
  name: string;
  color: string;
}

const MainPageHeading = ({ name, color }: IMainPageHeading) => {
  return (
    <div className={styles.sectionWrapper}>
      <div className={styles.sectionHeading} style={{ color: color }}>
        {name}
      </div>
      <div className={styles.colorBar} style={{ backgroundColor: color }} />
      <Link className={styles.link} to={"/developers-note/new"}>
        <div className={styles.addButton} style={{ backgroundColor: color }}>
          Create new note
        </div>
      </Link>
    </div>
  );
};

export default MainPageHeading;
