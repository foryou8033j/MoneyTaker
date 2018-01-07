-- It was created using Dbeaver...

CREATE TABLE 'mt_entity' (
  'guid' varchar(36) NOT NULL,
  'class' char(1) DEFAULT NULL,
  PRIMARY KEY ('guid')
) ENGINE=InnoDB DEFAULT CHARSET=utf8

CREATE TABLE 'mt_friendlist' (
  'uguid' varchar(36) NOT NULL,
  'friend_uguid' varchar(36) NOT NULL,
  'gguid' varchar(36) NOT NULL,
  'credit' int(3) DEFAULT '0',
  PRIMARY KEY ('uguid','friend_uguid'),
  KEY 'FK_friendlist_friend_uguid_user_uguid' ('friend_uguid'),
  KEY 'FK_friendlist_gguid_group_gguid' ('gguid'),
  CONSTRAINT 'FK_friendlist_friend_uguid_user_uguid' FOREIGN KEY ('friend_uguid') REFERENCES 'mt_user' ('uguid'),
  CONSTRAINT 'FK_friendlist_gguid_group_gguid' FOREIGN KEY ('gguid') REFERENCES 'mt_group' ('gguid'),
  CONSTRAINT 'FK_friendlist_uguid_user_uguid' FOREIGN KEY ('uguid') REFERENCES 'mt_user' ('uguid')
) ENGINE=InnoDB DEFAULT CHARSET=utf8

CREATE TABLE 'mt_group' (
  'gguid' varchar(36) NOT NULL,
  'name' varchar(45) DEFAULT NULL,
  'state' int(1) DEFAULT '0',
  PRIMARY KEY ('gguid'),
  CONSTRAINT 'FK_group_gguid_entity_guid' FOREIGN KEY ('gguid') REFERENCES 'mt_entity' ('guid'),
  CONSTRAINT 'FK_mt_group_gguid_mt_entity_guid' FOREIGN KEY ('gguid') REFERENCES 'mt_entity' ('guid')
) ENGINE=InnoDB DEFAULT CHARSET=utf8

-- mt_grouplist 현재 사용하지 않는 테이블
CREATE TABLE 'mt_grouplist' (
  'gguid' varchar(36) NOT NULL,
  'uguid' varchar(36) NOT NULL,
  'permission' int(2) DEFAULT NULL,
  PRIMARY KEY ('gguid','uguid'),
  KEY 'FK_grouplist_uguid_user_uguid' ('uguid'),
  CONSTRAINT 'FK_grouplist_gguid_group_gguid' FOREIGN KEY ('gguid') REFERENCES 'mt_group' ('gguid'),
  CONSTRAINT 'FK_grouplist_uguid_user_uguid' FOREIGN KEY ('uguid') REFERENCES 'mt_user' ('uguid')
) ENGINE=InnoDB DEFAULT CHARSET=utf8

CREATE TABLE 'mt_iou' (
  'guid' varchar(36) NOT NULL,
  'date' timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  'borrower_guid' varchar(36) NOT NULL,
  'lender_guid' varchar(36) NOT NULL,
  'start_date' datetime DEFAULT NULL,
  'end_date' datetime DEFAULT NULL,
  'cost' decimal(18,0) NOT NULL,
  'state' int(1) DEFAULT NULL,
  'text' varchar(140) DEFAULT NULL,
  PRIMARY KEY ('guid','date','borrower_guid','lender_guid'),
  KEY 'FK_iou_borrower_guid_entity_guid' ('borrower_guid'),
  KEY 'FK_iou_lender_guid_entity_guid' ('lender_guid'),
  CONSTRAINT 'FK_iou_borrower_guid_entity_guid' FOREIGN KEY ('borrower_guid') REFERENCES 'mt_entity' ('guid'),
  CONSTRAINT 'FK_iou_guid_entity_guid' FOREIGN KEY ('guid') REFERENCES 'mt_entity' ('guid'),
  CONSTRAINT 'FK_iou_lender_guid_entity_guid' FOREIGN KEY ('lender_guid') REFERENCES 'mt_entity' ('guid')
) ENGINE=InnoDB DEFAULT CHARSET=utf8

CREATE TABLE 'mt_user' (
  'uguid' varchar(36) NOT NULL,
  'name' varchar(45) DEFAULT NULL,
  'id' varchar(45) DEFAULT NULL,
  'pw' varchar(45) DEFAULT NULL,
  PRIMARY KEY ('uguid'),
  CONSTRAINT 'FK_user_uguid_entity_guid' FOREIGN KEY ('uguid') REFERENCES 'mt_entity' ('guid')
) ENGINE=InnoDB DEFAULT CHARSET=utf8