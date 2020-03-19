-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema app
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema app
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `app` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `app` ;

-- -----------------------------------------------------
-- Table `app`.`personne`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `app`.`personne` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nom` VARCHAR(45) NULL,
  `prenom` VARCHAR(45) NULL,
  `age` INT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `app`.`voiture`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `app`.`voiture` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `marque` VARCHAR(45) NULL,
  `nom` VARCHAR(45) NULL,
  `immatriculation` VARCHAR(45) NULL,
  `personne_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_voiture_personne_idx` (`personne_id` ASC) VISIBLE,
  CONSTRAINT `fk_voiture_personne`
    FOREIGN KEY (`personne_id`)
    REFERENCES `app`.`personne` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
