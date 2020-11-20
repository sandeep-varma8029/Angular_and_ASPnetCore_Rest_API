
//This Model specifies the outline of the api responses to get the dropdoens of Skills and their Proficiencies
export interface Employeq {

  id: number;
  name: string;
skillGroup: skillgroup[];
}
export interface skillgroup{
id: number;
name: string;
}
export interface Prof {

  id: number;
  name: string;
proficiencyGroup: profgroup[];
}
export interface profgroup{
id: number;
name: string;
}