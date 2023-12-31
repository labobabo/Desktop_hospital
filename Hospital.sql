PGDMP  4    #                {            Hospital    16.1    16.1     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    16398    Hospital    DATABASE     ~   CREATE DATABASE "Hospital" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Russia.1251';
    DROP DATABASE "Hospital";
                postgres    false                        2615    16399    Hospital    SCHEMA        CREATE SCHEMA "Hospital";
    DROP SCHEMA "Hospital";
                postgres    false            �            1259    16413    Doctors    TABLE     �   CREATE TABLE "Hospital"."Doctors" (
    id bigint NOT NULL,
    "Name" text,
    "Surname" text,
    login text,
    password text,
    age text
);
 !   DROP TABLE "Hospital"."Doctors";
       Hospital         heap    postgres    false    5            �            1259    16444 	   diagnoses    TABLE     P   CREATE TABLE "Hospital".diagnoses (
    id bigint NOT NULL,
    "Name " text
);
 !   DROP TABLE "Hospital".diagnoses;
       Hospital         heap    postgres    false    5            �            1259    16400    patients    TABLE     �   CREATE TABLE "Hospital".patients (
    "Name" text,
    "Surname" text,
    "Diagnos" text,
    id bigint NOT NULL,
    "Date" date,
    "Time" time without time zone
);
     DROP TABLE "Hospital".patients;
       Hospital         heap    postgres    false    5            �            1259    16434    patients_id_seq    SEQUENCE     |   CREATE SEQUENCE "Hospital".patients_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 *   DROP SEQUENCE "Hospital".patients_id_seq;
       Hospital          postgres    false    215    5            �           0    0    patients_id_seq    SEQUENCE OWNED BY     K   ALTER SEQUENCE "Hospital".patients_id_seq OWNED BY "Hospital".patients.id;
          Hospital          postgres    false    217            "           2604    16435    patients id    DEFAULT     r   ALTER TABLE ONLY "Hospital".patients ALTER COLUMN id SET DEFAULT nextval('"Hospital".patients_id_seq'::regclass);
 >   ALTER TABLE "Hospital".patients ALTER COLUMN id DROP DEFAULT;
       Hospital          postgres    false    217    215            �          0    16413    Doctors 
   TABLE DATA           T   COPY "Hospital"."Doctors" (id, "Name", "Surname", login, password, age) FROM stdin;
    Hospital          postgres    false    216          �          0    16444 	   diagnoses 
   TABLE DATA           4   COPY "Hospital".diagnoses (id, "Name ") FROM stdin;
    Hospital          postgres    false    218   |       �          0    16400    patients 
   TABLE DATA           X   COPY "Hospital".patients ("Name", "Surname", "Diagnos", id, "Date", "Time") FROM stdin;
    Hospital          postgres    false    215   �       �           0    0    patients_id_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('"Hospital".patients_id_seq', 39, true);
          Hospital          postgres    false    217            &           2606    16419    Doctors Doctors_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY "Hospital"."Doctors"
    ADD CONSTRAINT "Doctors_pkey" PRIMARY KEY (id);
 F   ALTER TABLE ONLY "Hospital"."Doctors" DROP CONSTRAINT "Doctors_pkey";
       Hospital            postgres    false    216            (           2606    16450    diagnoses diagnoses_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY "Hospital".diagnoses
    ADD CONSTRAINT diagnoses_pkey PRIMARY KEY (id);
 F   ALTER TABLE ONLY "Hospital".diagnoses DROP CONSTRAINT diagnoses_pkey;
       Hospital            postgres    false    218            $           2606    16442    patients patients_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY "Hospital".patients
    ADD CONSTRAINT patients_pkey PRIMARY KEY (id);
 D   ALTER TABLE ONLY "Hospital".patients DROP CONSTRAINT patients_pkey;
       Hospital            postgres    false    215            �   ]   x��-�0P�����.8��O $ ����;÷Q�K�܈y�="a�#N�T�Nԓ�s����Z�pX��a��P��z�*%W3�o*�      �      x�3�t�K��K�2��H�I-J����� K��      �   6   x�K-LBN��钙���_�Yl�il�id``�DFF��FV�V\1z\\\ ��/     