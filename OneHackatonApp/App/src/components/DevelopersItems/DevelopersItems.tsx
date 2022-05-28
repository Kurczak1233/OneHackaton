import { DeveloperItem } from "../MainTimeline/TimelineVm";
import styles from "./DevelopersItems.module.scss";

interface IDevelopersItems {
  developersItems: DeveloperItem[];
}
const DevelopersItems = ({ developersItems }: IDevelopersItems) => {
  return (
    <div className={styles.sidesItems}>
      {developersItems.map((item, index) => (
        <div className={styles.item} key={`${item.credentials} ${index}`}>
          <div className={styles.note}>Reports</div>
          <div className={styles.extensionBar} />
        </div>
      ))}
    </div>
  );
};

export default DevelopersItems;
