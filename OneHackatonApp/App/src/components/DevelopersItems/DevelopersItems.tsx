import styles from "./DevelopersItems.module.scss";

interface IDevelopersItems {
  developersItems: {
    name: string;
  }[];
}
const DevelopersItems = ({ developersItems }: IDevelopersItems) => {
  return (
    <div className={styles.sidesItems}>
      {developersItems.map((item, index) => (
        <div key={`${item.name} ${index}`} className={styles.item}>
          <div className={styles.note}>{item.name}</div>
          <div className={styles.extensionBar} />
        </div>
      ))}
    </div>
  );
};

export default DevelopersItems;
