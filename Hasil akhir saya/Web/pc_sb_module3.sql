-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 23, 2020 at 01:22 AM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.3.23

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pc_sb_module3`
--

-- --------------------------------------------------------

--
-- Table structure for table `access_token`
--

CREATE TABLE `access_token` (
  `id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `user_type` varchar(100) DEFAULT NULL,
  `type` varchar(100) DEFAULT NULL,
  `token` varchar(500) DEFAULT NULL,
  `expired_at` int(11) DEFAULT NULL,
  `created_at` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `access_token`
--

INSERT INTO `access_token` (`id`, `user_id`, `user_type`, `type`, `token`, `expired_at`, `created_at`) VALUES
(1, 0, 'siswa', NULL, '788c12d80ca73b03dbd67a4199e8a31e', 3600, '2020-10-22 05:44:32'),
(2, 0, 'siswa', NULL, '57e76d13159b4205379369416a5c090d', 3600, '2020-10-22 05:51:43'),
(3, 0, 'siswa', NULL, '0f6f98c2859ee38d87ce30d3e11967a0', 3600, '2020-10-22 05:52:48'),
(4, 0, 'siswa', NULL, '93ef1bf7e4348aee0de4ea745a9cd671', 3600, '2020-10-22 05:53:35'),
(5, 0, 'siswa', NULL, '6ec66737a558403a3d9ddbe4d19d3ac0', 3600, '2020-10-22 05:55:03'),
(6, 0, 'siswa', NULL, '2de2111dfdf12fe98d4b9d966894ff9b', 3600, '2020-10-22 05:55:28'),
(7, 0, 'siswa', NULL, 'f09d2c472bac18290874c956e2cc0c84', 3600, '2020-10-22 05:55:30'),
(8, 0, 'siswa', NULL, 'a527b677dbd9d97f659ec4ffd651e431', 3600, '2020-10-22 05:55:31'),
(9, 0, 'siswa', NULL, '74a2013e99d0ba088a879b76b0dc6c99', 3600, '2020-10-22 05:55:33'),
(10, 0, 'siswa', NULL, 'cf8295fdd8309e83193e3746d1233080', 3600, '2020-10-22 05:55:41'),
(11, 0, 'teacher', NULL, '65932b68dcd7e5dd3c20881e175fb652', 3600, '2020-10-22 06:01:47'),
(12, 0, 'teacher', NULL, '7b07782c458fa6eee93311dbbdfc6ecb', 3600, '2020-10-22 06:05:16'),
(13, 0, 'teacher', NULL, '8f73445ba84b01966ccfdf986125251c', 3600, '2020-10-22 06:05:18'),
(14, 0, 'teacher', NULL, '32c1f1e36cd65ef132042fa6cedd8c7c', 3600, '2020-10-22 06:05:19'),
(15, 0, 'teacher', NULL, 'db0565351591a1745401c7209592e0f5', 3600, '2020-10-22 06:05:20'),
(16, 0, 'teacher', NULL, '66a738576fe119befeec0f6b1e09b44c', 3600, '2020-10-22 06:05:21'),
(17, 0, 'teacher', NULL, '141f52921e60b202fae07c7a759fd218', 3600, '2020-10-22 06:05:23'),
(18, 0, 'teacher', NULL, 'fb3624ecdf43b6ef601c01e059bc6ddd', 3600, '2020-10-22 06:05:24'),
(19, 0, 'teacher', NULL, 'ce2f197c0f12e5e446915d864074f615', 3600, '2020-10-22 06:05:25'),
(20, 0, 'teacher', NULL, '4cfa8c4a2bd00742c2816a9169b6ae95', 3600, '2020-10-22 06:05:26'),
(21, 0, 'teacher', NULL, 'f9352d2243e80a586813c0df185b6b42', 3600, '2020-10-22 06:05:27'),
(22, 0, 'teacher', NULL, '08a68e9933e874fcbc1705a9382e0d86', 3600, '2020-10-22 07:13:27'),
(23, 0, 'siswa', NULL, '645562bafef43d9ad78b2f0f8bb14492', 3600, '2020-10-22 07:13:49'),
(24, 0, 'teacher', NULL, 'e80b17ace83e3c5bd35cf35f38c32390', 3600, '2020-10-22 09:14:38');

-- --------------------------------------------------------

--
-- Table structure for table `class`
--

CREATE TABLE `class` (
  `id` int(11) NOT NULL,
  `name` varchar(100) DEFAULT NULL,
  `period` varchar(100) DEFAULT NULL,
  `semester` varchar(50) DEFAULT NULL,
  `level` varchar(5) DEFAULT NULL,
  `teacher_id` int(11) DEFAULT NULL,
  `major` varchar(100) DEFAULT NULL,
  `created_at` datetime DEFAULT NULL,
  `deleted_at` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `class_detail`
--

CREATE TABLE `class_detail` (
  `class_id` int(11) NOT NULL,
  `student_id` int(11) NOT NULL,
  `created_at` datetime DEFAULT NULL,
  `deleted_at` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `score`
--

CREATE TABLE `score` (
  `id` int(11) NOT NULL,
  `score` int(11) NOT NULL,
  `class_id` int(11) NOT NULL,
  `subject_id` int(11) NOT NULL,
  `student_id` int(11) NOT NULL,
  `teacher_id` int(11) NOT NULL,
  `score_type` varchar(100) DEFAULT NULL,
  `notes` varchar(500) DEFAULT NULL,
  `created_at` datetime DEFAULT NULL,
  `deleted_at` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `id` int(11) NOT NULL,
  `name` varchar(100) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `password` varchar(500) DEFAULT NULL,
  `registered_number` varchar(50) DEFAULT NULL,
  `image_path` varchar(500) DEFAULT NULL,
  `status` varchar(100) DEFAULT NULL,
  `created_at` datetime DEFAULT NULL,
  `deleted_at` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`id`, `name`, `email`, `password`, `registered_number`, `image_path`, `status`, `created_at`, `deleted_at`) VALUES
(0, 'azim\r\n', 'alazim520@gmail.com', '4619acc1aa4c20f3329de890b1521740', '10', '/document/sekolah.daring.org/images/student/SSD1100001.jpg', 'active', '2020-10-01 10:10:10', '2020-10-01 10:10:10');

-- --------------------------------------------------------

--
-- Table structure for table `subject`
--

CREATE TABLE `subject` (
  `id` int(11) NOT NULL,
  `name` varchar(100) DEFAULT NULL,
  `level` varchar(5) DEFAULT NULL,
  `semester` varchar(50) DEFAULT NULL,
  `major` varchar(50) DEFAULT NULL,
  `description` varchar(500) DEFAULT NULL,
  `created_at` datetime DEFAULT NULL,
  `deleted_at` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `teacher`
--

CREATE TABLE `teacher` (
  `id` int(11) NOT NULL,
  `name` varchar(100) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `password` varchar(500) DEFAULT NULL,
  `registered_number` varchar(50) DEFAULT NULL,
  `image_path` varchar(500) DEFAULT NULL,
  `status` varchar(100) DEFAULT NULL,
  `created_at` datetime DEFAULT NULL,
  `deleted_at` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `teacher`
--

INSERT INTO `teacher` (`id`, `name`, `email`, `password`, `registered_number`, `image_path`, `status`, `created_at`, `deleted_at`) VALUES
(0, 'adalah', 'adalah@gmail.com', '5d7845ac6ee7cfffafc5fe5f35cf666d', '1', '/document/.png', 'pns', '2020-10-22 10:56:28', NULL);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `access_token`
--
ALTER TABLE `access_token`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `class`
--
ALTER TABLE `class`
  ADD PRIMARY KEY (`id`),
  ADD KEY `teacher_id` (`teacher_id`);

--
-- Indexes for table `class_detail`
--
ALTER TABLE `class_detail`
  ADD PRIMARY KEY (`class_id`,`student_id`),
  ADD KEY `student_id` (`student_id`);

--
-- Indexes for table `score`
--
ALTER TABLE `score`
  ADD PRIMARY KEY (`id`),
  ADD KEY `teacher_id` (`teacher_id`),
  ADD KEY `student_id` (`student_id`),
  ADD KEY `subject_id` (`subject_id`),
  ADD KEY `class_id` (`class_id`);

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `subject`
--
ALTER TABLE `subject`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `teacher`
--
ALTER TABLE `teacher`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `access_token`
--
ALTER TABLE `access_token`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `class`
--
ALTER TABLE `class`
  ADD CONSTRAINT `class_ibfk_1` FOREIGN KEY (`teacher_id`) REFERENCES `teacher` (`id`);

--
-- Constraints for table `class_detail`
--
ALTER TABLE `class_detail`
  ADD CONSTRAINT `class_detail_ibfk_1` FOREIGN KEY (`class_id`) REFERENCES `class` (`id`),
  ADD CONSTRAINT `class_detail_ibfk_2` FOREIGN KEY (`student_id`) REFERENCES `student` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
