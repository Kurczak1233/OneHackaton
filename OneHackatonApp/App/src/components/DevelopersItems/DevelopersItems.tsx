import styles from "./DevelopersItems.module.scss";

interface IDevelopersItems {
  developersItems: {
    name: string;
    id: number;
  }[];
}
const DevelopersItems = ({ developersItems }: IDevelopersItems) => {
  return (
    <div className={styles.sidesItems}>
      {developersItems.map((item, index) => (
        <div className={styles.item} key={`${item.name} ${index}`}>
          <div className={styles.note}>{item.name}</div>
          <div className={styles.extensionBar} />
        </div>
      ))}
    </div>
  );
};

export default DevelopersItems;
