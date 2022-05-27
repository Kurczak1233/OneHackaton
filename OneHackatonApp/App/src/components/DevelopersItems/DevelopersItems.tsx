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
          {item.name}
          <div className={styles.extensionBar} />
          <div></div>
        </div>
      ))}
    </div>
  );
};

export default DevelopersItems;
