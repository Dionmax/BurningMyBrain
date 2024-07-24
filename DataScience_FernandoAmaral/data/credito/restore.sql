--
-- NOTE:
--
-- File paths need to be edited. Search for $$PATH$$ and
-- replace it with the path to the directory containing
-- the extracted data files.
--
--
-- PostgreSQL database dump
--

-- Dumped from database version 10.10
-- Dumped by pg_dump version 10.10

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

-- Drop existing tables and constraints
-- ALTER TABLE ONLY public."CLIENTES" DROP CONSTRAINT clientes_pkey;
-- ALTER TABLE ONLY public."PROPOSITO" DROP CONSTRAINT "PROPOSITO_pkey";
-- ALTER TABLE ONLY public."PROFISSAO" DROP CONSTRAINT "PROFISSAO_pkey";
-- ALTER TABLE ONLY public."OUTROSFINANC" DROP CONSTRAINT "OUTROSFINANC_pkey";
-- ALTER TABLE ONLY public."INVESTIMENTOS" DROP CONSTRAINT "INVESTIMENTOS_pkey";
-- ALTER TABLE ONLY public."HISTORICO_CREDITO" DROP CONSTRAINT "HISTORICO_CREDITO_pkey";
-- ALTER TABLE ONLY public."HABITACAO" DROP CONSTRAINT "HABITACAO_pkey";
-- ALTER TABLE ONLY public."FIADOR" DROP CONSTRAINT "FIADOR_pkey";
-- ALTER TABLE ONLY public."ESTADOCIVIL" DROP CONSTRAINT "ESTADOCIVIL_pkey";
-- ALTER TABLE ONLY public."EMPREGO" DROP CONSTRAINT "EMPREGO_pkey";
-- ALTER TABLE ONLY public."CREDITO" DROP CONSTRAINT "CREDITO_pkey";
-- DROP TABLE public."PROPOSITO";
-- DROP TABLE public."PROFISSAO";
-- DROP TABLE public."OUTROSFINANC";
-- DROP TABLE public."INVESTIMENTOS";
-- DROP TABLE public."HISTORICO_CREDITO";
-- DROP TABLE public."HABITACAO";
-- DROP TABLE public."FIADOR";
-- DROP TABLE public."ESTADOCIVIL";
-- DROP TABLE public."EMPREGO";
-- DROP TABLE public."CREDITO";
-- DROP TABLE public."CLIENTES";
-- DROP SEQUENCE public.idcliente;
-- DROP EXTENSION plpgsql;
-- DROP SCHEMA public;

-- Create schema and extensions
CREATE SCHEMA public;
ALTER SCHEMA public OWNER TO postgres;
COMMENT ON SCHEMA public IS 'standard public schema';

CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;
COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';

-- Create sequences
CREATE SEQUENCE public.idcliente
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
ALTER TABLE public.idcliente OWNER TO postgres;

SET default_tablespace = '';
SET default_with_oids = false;

-- Create tables
CREATE TABLE public."CLIENTES" (
    idcliente integer DEFAULT nextval('public.idcliente'::regclass) NOT NULL,
    cliente character varying(50),
    estado character varying(2),
    sexo character(1)
);
ALTER TABLE public."CLIENTES" OWNER TO postgres;

CREATE TABLE public."CREDITO" (
    "IDCREDITO" integer NOT NULL,
    "Duracao" integer,
    "HistoricoCredito" integer,
    "Proposito" integer,
    "Valor" integer,
    "Investimentos" integer,
    "Emprego" integer,
    "TempoParcelamento" integer,
    "EstadoCivil" integer,
    "FiadorTerceiros" integer,
    "ResidenciaDesde" integer,
    "Idade" integer,
    "OutrosFinanciamentos" integer,
    "Habitacao" integer,
    "EmprestimoExistente" integer,
    "Profissao" integer,
    "Dependentes" integer,
    "SocioEmpresa" integer,
    "Estrangeiro" integer,
    "Status" integer
);
ALTER TABLE public."CREDITO" OWNER TO postgres;

CREATE TABLE public."EMPREGO" (
    "IDEMPREGO" integer NOT NULL,
    "EMPREGO" character varying(100) NOT NULL
);
ALTER TABLE public."EMPREGO" OWNER TO postgres;

CREATE TABLE public."ESTADOCIVIL" (
    "IDESTADOCIVIL" integer NOT NULL,
    "ESTADOCIVIL" character varying(100) NOT NULL
);
ALTER TABLE public."ESTADOCIVIL" OWNER TO postgres;

CREATE TABLE public."FIADOR" (
    "IDFIADOR" integer NOT NULL,
    "FIADOR" character varying(100) NOT NULL
);
ALTER TABLE public."FIADOR" OWNER TO postgres;

CREATE TABLE public."HABITACAO" (
    "IDHABITACAO" integer NOT NULL,
    "HABITACAO" character varying(100) NOT NULL
);
ALTER TABLE public."HABITACAO" OWNER TO postgres;

CREATE TABLE public."HISTORICO_CREDITO" (
    "IDHISTCRED" integer NOT NULL,
    "HISTORICO" character varying(100) NOT NULL
);
ALTER TABLE public."HISTORICO_CREDITO" OWNER TO postgres;

CREATE TABLE public."INVESTIMENTOS" (
    "IDINVESTIMENTOS" integer NOT NULL,
    "INVESTIMENTOS" character varying(100) NOT NULL
);
ALTER TABLE public."INVESTIMENTOS" OWNER TO postgres;

CREATE TABLE public."OUTROSFINANC" (
    "IDOUTROSFINANC" integer NOT NULL,
    "OUTROSFINANCIAMENTOS" character varying(100) NOT NULL
);
ALTER TABLE public."OUTROSFINANC" OWNER TO postgres;

CREATE TABLE public."PROFISSAO" (
    "IDPROFISSAO" integer NOT NULL,
    "PROFISSAO" character varying(100) NOT NULL
);
ALTER TABLE public."PROFISSAO" OWNER TO postgres;

CREATE TABLE public."PROPOSITO" (
    "IDPROPOSITO" integer NOT NULL,
    "PROPOSITO" character varying(100) NOT NULL
);
ALTER TABLE public."PROPOSITO" OWNER TO postgres;

-- Insert data
COPY public."CLIENTES" (idcliente, cliente, estado, sexo) FROM '/var/lib/postgresql/data/credito/2865.dat';
COPY public."CREDITO" ("IDCREDITO", "Duracao", "HistoricoCredito", "Proposito", "Valor", "Investimentos", "Emprego", "TempoParcelamento", "EstadoCivil", "FiadorTerceiros", "ResidenciaDesde", "Idade", "OutrosFinanciamentos", "Habitacao", "EmprestimoExistente", "Profissao", "Dependentes", "SocioEmpresa", "Estrangeiro", "Status") FROM '/var/lib/postgresql/data/credito/2866.dat';
COPY public."EMPREGO" ("IDEMPREGO", "EMPREGO") FROM '/var/lib/postgresql/data/credito/2858.dat';
COPY public."ESTADOCIVIL" ("IDESTADOCIVIL", "ESTADOCIVIL") FROM '/var/lib/postgresql/data/credito/2863.dat';
COPY public."FIADOR" ("IDFIADOR", "FIADOR") FROM '/var/lib/postgresql/data/credito/2861.dat';
COPY public."HABITACAO" ("IDHABITACAO", "HABITACAO") FROM '/var/lib/postgresql/data/credito/2857.dat';
COPY public."HISTORICO_CREDITO" ("IDHISTCRED", "HISTORICO") FROM '/var/lib/postgresql/data/credito/2855.dat';
COPY public."INVESTIMENTOS" ("IDINVESTIMENTOS", "INVESTIMENTOS") FROM '/var/lib/postgresql/data/credito/2860.dat';
COPY public."OUTROSFINANC" ("IDOUTROSFINANC", "OUTROSFINANCIAMENTOS") FROM '/var/lib/postgresql/data/credito/2862.dat';
COPY public."PROFISSAO" ("IDPROFISSAO", "PROFISSAO") FROM '/var/lib/postgresql/data/credito/2859.dat';
COPY public."PROPOSITO" ("IDPROPOSITO", "PROPOSITO") FROM '/var/lib/postgresql/data/credito/2856.dat';

-- Set sequence value
SELECT pg_catalog.setval('public.idcliente', 250, true);

-- Add primary keys
ALTER TABLE ONLY public."CREDITO"
    ADD CONSTRAINT "CREDITO_pkey" PRIMARY KEY ("IDCREDITO");

ALTER TABLE ONLY public."EMPREGO"
    ADD CONSTRAINT "EMPREGO_pkey" PRIMARY KEY ("IDEMPREGO");

ALTER TABLE ONLY public."ESTADOCIVIL"
    ADD CONSTRAINT "ESTADOCIVIL_pkey" PRIMARY KEY ("IDESTADOCIVIL");

ALTER TABLE ONLY public."FIADOR"
    ADD CONSTRAINT "FIADOR_pkey" PRIMARY KEY ("IDFIADOR");

ALTER TABLE ONLY public."HABITACAO"
    ADD CONSTRAINT "HABITACAO_pkey" PRIMARY KEY ("IDHABITACAO");

ALTER TABLE ONLY public."HISTORICO_CREDITO"
    ADD CONSTRAINT "HISTORICO_CREDITO_pkey" PRIMARY KEY ("IDHISTCRED");

ALTER TABLE ONLY public."INVESTIMENTOS"
    ADD CONSTRAINT "INVESTIMENTOS_pkey" PRIMARY KEY ("IDINVESTIMENTOS");

ALTER TABLE ONLY public."OUTROSFINANC"
    ADD CONSTRAINT "OUTROSFINANC_pkey" PRIMARY KEY ("IDOUTROSFINANC");

ALTER TABLE ONLY public."PROFISSAO"
    ADD CONSTRAINT "PROFISSAO_pkey" PRIMARY KEY ("IDPROFISSAO");

ALTER TABLE ONLY public."PROPOSITO"
    ADD CONSTRAINT "PROPOSITO_pkey" PRIMARY KEY ("IDPROPOSITO");

ALTER TABLE ONLY public."CLIENTES"
    ADD CONSTRAINT clientes_pkey PRIMARY KEY (idcliente);
