import { ClientItem } from "../MainTimeline/TimelineVm";
import styles from "./ClientItems.module.scss";

interface IClientItems {
  usersItems: ClientItem[];
}

const ClientItems = ({ usersItems }: IClientItems) => {
  return (
    <div className={styles.sidesItems}>
      {usersItems.map((item, index) => (
        <div key={`${item.credentials} ${index}`} className={styles.item}>
          <div className={styles.extensionBar} />
          <div className={styles.note}>Reports</div>
        </div>
      ))}
    </div>
  );
};

export default ClientItems;
