CREATE TABLE "public.Pacient" (
	"Id" serial NOT NULL,
	"UserId" integer NOT NULL,
	"HillHistoryId" integer NOT NULL,
	CONSTRAINT "Pacient_pk" PRIMARY KEY ("Id")
) WITH (
  OIDS=FALSE
);



CREATE TABLE "public.Diagnos" (
	"Id" serial NOT NULL,
	"Name" VARCHAR(255) NOT NULL,
	"Description" TEXT NOT NULL,
	"TreatmentPlanId" integer NOT NULL,
	CONSTRAINT "Diagnos_pk" PRIMARY KEY ("Id")
) WITH (
  OIDS=FALSE
);



CREATE TABLE "public.Schedule" (
	"Id" serial NOT NULL,
	"DoctorId" integer NOT NULL,
	"TimeOfReceipt" DATETIME NOT NULL,
	"CabinetNumber" integer NOT NULL,
	"PacientId" integer NOT NULL,
	CONSTRAINT "Schedule_pk" PRIMARY KEY ("Id")
) WITH (
  OIDS=FALSE
);



CREATE TABLE "public.Doctor" (
	"Id" serial NOT NULL,
	"UserId" integer NOT NULL,
	"Speciality" VARCHAR(255) NOT NULL,
	"PacientId" integer NOT NULL,
	CONSTRAINT "Doctor_pk" PRIMARY KEY ("Id")
) WITH (
  OIDS=FALSE
);



CREATE TABLE "public.User" (
	"Id" serial NOT NULL,
	"FirstName" VARCHAR(255) NOT NULL,
	"LastName" VARCHAR(255) NOT NULL,
	"Patronymic" VARCHAR(255) NOT NULL,
	CONSTRAINT "User_pk" PRIMARY KEY ("Id")
) WITH (
  OIDS=FALSE
);



CREATE TABLE "public.Analyses" (
	"Id" serial NOT NULL,
	"AnalyseName" integer NOT NULL,
	"Results" TEXT NOT NULL,
	"IsDone" BOOLEAN NOT NULL,
	CONSTRAINT "Analyses_pk" PRIMARY KEY ("Id")
) WITH (
  OIDS=FALSE
);



CREATE TABLE "public.HillHistory" (
	"Id" serial NOT NULL,
	"AnalysesId" integer NOT NULL,
	"DiagId" integer NOT NULL,
	CONSTRAINT "HillHistory_pk" PRIMARY KEY ("Id")
) WITH (
  OIDS=FALSE
);



CREATE TABLE "public.TreatmentPlan" (
	"Id" serial NOT NULL,
	"ProcedureName" VARCHAR(255) NOT NULL,
	"Description" TEXT NOT NULL,
	CONSTRAINT "TreatmentPlan_pk" PRIMARY KEY ("Id")
) WITH (
  OIDS=FALSE
);



ALTER TABLE "Pacient" ADD CONSTRAINT "Pacient_fk0" FOREIGN KEY ("UserId") REFERENCES "User"("Id");
ALTER TABLE "Pacient" ADD CONSTRAINT "Pacient_fk1" FOREIGN KEY ("HillHistoryId") REFERENCES "HillHistory"("Id");

ALTER TABLE "Diagnos" ADD CONSTRAINT "Diagnos_fk0" FOREIGN KEY ("TreatmentPlanId") REFERENCES "TreatmentPlan"("Id");

ALTER TABLE "Schedule" ADD CONSTRAINT "Schedule_fk0" FOREIGN KEY ("DoctorId") REFERENCES "Doctor"("Id");
ALTER TABLE "Schedule" ADD CONSTRAINT "Schedule_fk1" FOREIGN KEY ("PacientId") REFERENCES "Pacient"("Id");

ALTER TABLE "Doctor" ADD CONSTRAINT "Doctor_fk0" FOREIGN KEY ("UserId") REFERENCES "User"("Id");
ALTER TABLE "Doctor" ADD CONSTRAINT "Doctor_fk1" FOREIGN KEY ("PacientId") REFERENCES "Pacient"("Id");



ALTER TABLE "HillHistory" ADD CONSTRAINT "HillHistory_fk0" FOREIGN KEY ("AnalysesId") REFERENCES "Analyses"("Id");
ALTER TABLE "HillHistory" ADD CONSTRAINT "HillHistory_fk1" FOREIGN KEY ("DiagId") REFERENCES "Diagnos"("Id");










