-- It was created using Dbeaver...

-- 트리거 일람 SQL문으로 입력할 필요 있음.

-- 'group_before_insert' - BEFORE INSERT mt_group

DROP TRIGGER IF EXISTS MoneyTaker.group_before_insert ;

DELIMITER $$
$$
CREATE TRIGGER MoneyTaker.group_before_insert
BEFORE INSERT
ON MoneyTaker.mt_group FOR EACH ROW
BEGIN
#	IF NOT EXISTS (SELECT * FROM mt_entity WHERE guid = NEW.gguid )
		INSERT INTO MoneyTaker.mt_entity
			(guid, class)
			VALUES
			( NEW.gguid ,'u');
#	END IF
END $$
DELIMITER ;


-- 'user_before_insert' - BEFORE INSERT mt_user
DROP TRIGGER IF EXISTS MoneyTaker.user_before_insert ;

DELIMITER $$
$$
CREATE TRIGGER MoneyTaker.user_before_insert
BEFORE INSERT
ON MoneyTaker.mt_user FOR EACH ROW
BEGIN
#	IF NOT EXISTS (SELECT * FROM mt_entity WHERE guid = id )
		INSERT INTO MoneyTaker.mt_entity
			(guid, class)
			VALUES
			( NEW.uguid ,'u');
#	END IF
END $$
DELIMITER ;