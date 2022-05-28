export interface TimelineVm {
  id: number;
  date: Date;
  developerItems: DeveloperItem[];
  userItems: ClientItem[];
}
export interface DeveloperItem {
  id: number;
  credentials: string;
  email: string;
  description: string;
  date: Date;
  timelineId: number;
}

export interface ClientItem {
  id: number;
  credentials: string;
  email: string;
  description: string;
  date: Date;
  timelineId: number;
}
