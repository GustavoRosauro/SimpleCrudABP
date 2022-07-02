import type { AuditedEntityDto } from '@abp/ng.core';

export interface CreateUpdatePersonDto {
  name: string;
  email: string;
  idade: number;
}

export interface PersonDto extends AuditedEntityDto<string> {
  name?: string;
  email?: string;
  idade: number;
}
