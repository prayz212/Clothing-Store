using System;
using System.Collections.Generic;
using Clothing_Store.Models;
using Microsoft.EntityFrameworkCore;

namespace Clothing_Store.Utils
{
    public static class ModelBuilderExtensions
    {
        private static List<string> PRODUCT_TYPE = new List<string>() { "Áo thun tay dài", "Áo thun tay ngắn", "Áo sơ mi tay dài", "Áo sơ mi tay ngắn", "Quần dài", "Quần ngắn" };
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tag>().HasData(
                new Tag { ID = 1, Name = "San Pham Moi", IsDelete = false },
                new Tag { ID = 2, Name = "San Pham Ban Chay", IsDelete = false },
                new Tag { ID = 3, Name = "San Pham Duoc Ua Thich", IsDelete = false },
                new Tag { ID = 4, Name = "Ao Thun Thoi Trang", IsDelete = false },
                new Tag { ID = 5, Name = "Ao Thun Hien Dai", IsDelete = false },
                new Tag { ID = 6, Name = "Ao Thun Cotton", IsDelete = false },
                new Tag { ID = 7, Name = "Ao So Mi Cotton", IsDelete = false },
                new Tag { ID = 8, Name = "Ao So Mi Cong So", IsDelete = false },
                new Tag { ID = 9, Name = "Ao So Mi Tay Ngan", IsDelete = false },
                new Tag { ID = 10, Name = "Ao So Mi Tay Dai", IsDelete = false },
                new Tag { ID = 11, Name = "Thoi Trang Tre", IsDelete = false },
                new Tag { ID = 12, Name = "Thoi Trang Nang Dong", IsDelete = false },
                new Tag { ID = 13, Name = "Thoi Trang Teen", IsDelete = false },
                new Tag { ID = 14, Name = "Thoi Trang Cong So", IsDelete = false },
                new Tag { ID = 15, Name = "Quan Di Choi", IsDelete = false },
                new Tag { ID = 16, Name = "Quan Cong So", IsDelete = false }
            );

            modelBuilder.Entity<Product>().HasData(
                //Ao thun tay dai
                new Product { ID = 1, Name = "Áo Thun Tay Dài D001", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 2, Name = "Áo Thun Tay Dài D002", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 3, Name = "Áo Thun Tay Dài D003", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 4, Name = "Áo Thun Tay Dài D004", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 5, Name = "Áo Thun Tay Dài D005", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 6, Name = "Áo Thun Tay Dài D006", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 7, Name = "Áo Thun Tay Dài D007", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 8, Name = "Áo Thun Tay Dài D008", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 9, Name = "Áo Thun Tay Dài D009", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 10, Name = "Áo Thun Tay Dài D010", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 11, Name = "Áo Thun Tay Dài D011", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 12, Name = "Áo Thun Tay Dài D012", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 13, Name = "Áo Thun Tay Dài D013", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 14, Name = "Áo Thun Tay Dài D014", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 15, Name = "Áo Thun Tay Dài D015", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 16, Name = "Áo Thun Tay Dài D016", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 17, Name = "Áo Thun Tay Dài D017", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 18, Name = "Áo Thun Tay Dài D018", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 19, Name = "Áo Thun Tay Dài D019", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                //Ao thun tay ngan
                new Product { ID = 20, Name = "Áo Thun Tay Ngắn N001", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 21, Name = "Áo Thun Tay Ngắn N002", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 22, Name = "Áo Thun Tay Ngắn N003", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 23, Name = "Áo Thun Tay Ngắn N004", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 24, Name = "Áo Thun Tay Ngắn N005", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 25, Name = "Áo Thun Tay Ngắn N006", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 26, Name = "Áo Thun Tay Ngắn N007", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 27, Name = "Áo Thun Tay Ngắn N008", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 28, Name = "Áo Thun Tay Ngắn N009", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 29, Name = "Áo Thun Tay Ngắn N010", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 30, Name = "Áo Thun Tay Ngắn N011", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 31, Name = "Áo Thun Tay Ngắn N012", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 32, Name = "Áo Thun Tay Ngắn N013", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 33, Name = "Áo Thun Tay Ngắn N014", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 34, Name = "Áo Thun Tay Ngắn N015", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 35, Name = "Áo Thun Tay Ngắn N016", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 36, Name = "Áo Thun Tay Ngắn N017", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 37, Name = "Áo Thun Tay Ngắn N018", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 38, Name = "Áo Thun Tay Ngắn N019", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                //Ao so mi tay dai
                new Product { ID = 39, Name = "Áo Sơ Mi D001", Description = GetRandomDescription(PRODUCT_TYPE[2]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[2], Visible = true, IsDelete = false },
                new Product { ID = 40, Name = "Áo Sơ Mi D002", Description = GetRandomDescription(PRODUCT_TYPE[2]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[2], Visible = true, IsDelete = false },
                new Product { ID = 41, Name = "Áo Sơ Mi D003", Description = GetRandomDescription(PRODUCT_TYPE[2]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[2], Visible = true, IsDelete = false },
                new Product { ID = 42, Name = "Áo Sơ Mi D004", Description = GetRandomDescription(PRODUCT_TYPE[2]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[2], Visible = true, IsDelete = false },
                new Product { ID = 43, Name = "Áo Sơ Mi D005", Description = GetRandomDescription(PRODUCT_TYPE[2]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[2], Visible = true, IsDelete = false },
                new Product { ID = 44, Name = "Áo Sơ Mi D006", Description = GetRandomDescription(PRODUCT_TYPE[2]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[2], Visible = true, IsDelete = false },
                new Product { ID = 45, Name = "Áo Sơ Mi D007", Description = GetRandomDescription(PRODUCT_TYPE[2]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[2], Visible = true, IsDelete = false },
                new Product { ID = 46, Name = "Áo Sơ Mi D008", Description = GetRandomDescription(PRODUCT_TYPE[2]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[2], Visible = true, IsDelete = false },
                new Product { ID = 47, Name = "Áo Sơ Mi D009", Description = GetRandomDescription(PRODUCT_TYPE[2]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[2], Visible = true, IsDelete = false },
                new Product { ID = 48, Name = "Áo Sơ Mi D010", Description = GetRandomDescription(PRODUCT_TYPE[2]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[2], Visible = true, IsDelete = false },
                new Product { ID = 49, Name = "Áo Sơ Mi D011", Description = GetRandomDescription(PRODUCT_TYPE[2]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[2], Visible = true, IsDelete = false },
                //Ao so mi tay ngan
                new Product { ID = 50, Name = "Áo Sơ Mi N001", Description = GetRandomDescription(PRODUCT_TYPE[3]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[3], Visible = true, IsDelete = false },
                new Product { ID = 51, Name = "Áo Sơ Mi N002", Description = GetRandomDescription(PRODUCT_TYPE[3]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[3], Visible = true, IsDelete = false },
                new Product { ID = 52, Name = "Áo Sơ Mi N003", Description = GetRandomDescription(PRODUCT_TYPE[3]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[3], Visible = true, IsDelete = false },
                new Product { ID = 53, Name = "Áo Sơ Mi N004", Description = GetRandomDescription(PRODUCT_TYPE[3]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[3], Visible = true, IsDelete = false },
                new Product { ID = 54, Name = "Áo Sơ Mi N005", Description = GetRandomDescription(PRODUCT_TYPE[3]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[3], Visible = true, IsDelete = false },
                new Product { ID = 55, Name = "Áo Sơ Mi N006", Description = GetRandomDescription(PRODUCT_TYPE[3]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[3], Visible = true, IsDelete = false },
                new Product { ID = 56, Name = "Áo Sơ Mi N007", Description = GetRandomDescription(PRODUCT_TYPE[3]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[3], Visible = true, IsDelete = false },
                new Product { ID = 57, Name = "Áo Sơ Mi N008", Description = GetRandomDescription(PRODUCT_TYPE[3]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[3], Visible = true, IsDelete = false },
                new Product { ID = 58, Name = "Áo Sơ Mi N009", Description = GetRandomDescription(PRODUCT_TYPE[3]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[3], Visible = true, IsDelete = false },
                new Product { ID = 59, Name = "Áo Sơ Mi N010", Description = GetRandomDescription(PRODUCT_TYPE[3]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[3], Visible = true, IsDelete = false },
                new Product { ID = 60, Name = "Áo Sơ Mi N011", Description = GetRandomDescription(PRODUCT_TYPE[3]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[3], Visible = true, IsDelete = false },
                new Product { ID = 61, Name = "Áo Sơ Mi N012", Description = GetRandomDescription(PRODUCT_TYPE[3]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[3], Visible = true, IsDelete = false },
                new Product { ID = 62, Name = "Áo Sơ Mi N013", Description = GetRandomDescription(PRODUCT_TYPE[3]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[3], Visible = true, IsDelete = false },
                //Quan dai
                new Product { ID = 63, Name = "Quần Dài QD001", Description = GetRandomDescription(PRODUCT_TYPE[4]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[4], Visible = true, IsDelete = false },
                new Product { ID = 64, Name = "Quần Dài QD002", Description = GetRandomDescription(PRODUCT_TYPE[4]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[4], Visible = true, IsDelete = false },
                new Product { ID = 65, Name = "Quần Dài QD003", Description = GetRandomDescription(PRODUCT_TYPE[4]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[4], Visible = true, IsDelete = false },
                new Product { ID = 66, Name = "Quần Dài QD004", Description = GetRandomDescription(PRODUCT_TYPE[4]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[4], Visible = true, IsDelete = false },
                new Product { ID = 67, Name = "Quần Dài QD005", Description = GetRandomDescription(PRODUCT_TYPE[4]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[4], Visible = true, IsDelete = false },
                new Product { ID = 68, Name = "Quần Dài QD006", Description = GetRandomDescription(PRODUCT_TYPE[4]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[4], Visible = true, IsDelete = false },
                new Product { ID = 69, Name = "Quần Dài QD007", Description = GetRandomDescription(PRODUCT_TYPE[4]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[4], Visible = true, IsDelete = false },
                new Product { ID = 70, Name = "Quần Dài QD008", Description = GetRandomDescription(PRODUCT_TYPE[4]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[4], Visible = true, IsDelete = false },
                new Product { ID = 71, Name = "Quần Dài QD009", Description = GetRandomDescription(PRODUCT_TYPE[4]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[4], Visible = true, IsDelete = false },
                new Product { ID = 72, Name = "Quần Dài QD010", Description = GetRandomDescription(PRODUCT_TYPE[4]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[4], Visible = true, IsDelete = false },
                new Product { ID = 73, Name = "Quần Dài QD011", Description = GetRandomDescription(PRODUCT_TYPE[4]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[4], Visible = true, IsDelete = false },
                new Product { ID = 74, Name = "Quần Dài QD012", Description = GetRandomDescription(PRODUCT_TYPE[4]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[4], Visible = true, IsDelete = false },
                new Product { ID = 75, Name = "Quần Dài QD013", Description = GetRandomDescription(PRODUCT_TYPE[4]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[4], Visible = true, IsDelete = false },
                new Product { ID = 76, Name = "Quần Dài QD014", Description = GetRandomDescription(PRODUCT_TYPE[4]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[4], Visible = true, IsDelete = false },
                new Product { ID = 77, Name = "Quần Dài QD015", Description = GetRandomDescription(PRODUCT_TYPE[4]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[4], Visible = true, IsDelete = false },
                new Product { ID = 78, Name = "Quần Dài QD016", Description = GetRandomDescription(PRODUCT_TYPE[4]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[4], Visible = true, IsDelete = false },
                new Product { ID = 79, Name = "Quần Dài QD017", Description = GetRandomDescription(PRODUCT_TYPE[4]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[4], Visible = true, IsDelete = false },
                new Product { ID = 80, Name = "Quần Dài QD018", Description = GetRandomDescription(PRODUCT_TYPE[4]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[4], Visible = true, IsDelete = false },
                new Product { ID = 81, Name = "Quần Dài QD019", Description = GetRandomDescription(PRODUCT_TYPE[4]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[4], Visible = true, IsDelete = false },
                new Product { ID = 82, Name = "Quần Dài QD020", Description = GetRandomDescription(PRODUCT_TYPE[4]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[4], Visible = true, IsDelete = false },
                //Quan ngan
                new Product { ID = 83, Name = "Quần Ngắn QN001", Description = GetRandomDescription(PRODUCT_TYPE[5]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[5], Visible = true, IsDelete = false },
                new Product { ID = 84, Name = "Quần Ngắn QN002", Description = GetRandomDescription(PRODUCT_TYPE[5]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[5], Visible = true, IsDelete = false },
                new Product { ID = 85, Name = "Quần Ngắn QN003", Description = GetRandomDescription(PRODUCT_TYPE[5]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[5], Visible = true, IsDelete = false },
                new Product { ID = 86, Name = "Quần Ngắn QN004", Description = GetRandomDescription(PRODUCT_TYPE[5]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[5], Visible = true, IsDelete = false },
                new Product { ID = 87, Name = "Quần Ngắn QN005", Description = GetRandomDescription(PRODUCT_TYPE[5]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[5], Visible = true, IsDelete = false },
                new Product { ID = 88, Name = "Quần Ngắn QN006", Description = GetRandomDescription(PRODUCT_TYPE[5]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[5], Visible = true, IsDelete = false },
                new Product { ID = 89, Name = "Quần Ngắn QN007", Description = GetRandomDescription(PRODUCT_TYPE[5]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[5], Visible = true, IsDelete = false },
                new Product { ID = 90, Name = "Quần Ngắn QN008", Description = GetRandomDescription(PRODUCT_TYPE[5]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[5], Visible = true, IsDelete = false },
                new Product { ID = 91, Name = "Quần Ngắn QN009", Description = GetRandomDescription(PRODUCT_TYPE[5]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[5], Visible = true, IsDelete = false },
                new Product { ID = 92, Name = "Quần Ngắn QN010", Description = GetRandomDescription(PRODUCT_TYPE[5]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[5], Visible = true, IsDelete = false },
                new Product { ID = 93, Name = "Quần Ngắn QN011", Description = GetRandomDescription(PRODUCT_TYPE[5]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[5], Visible = true, IsDelete = false },
                new Product { ID = 94, Name = "Quần Ngắn QN012", Description = GetRandomDescription(PRODUCT_TYPE[5]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[5], Visible = true, IsDelete = false },
                new Product { ID = 95, Name = "Quần Ngắn QN013", Description = GetRandomDescription(PRODUCT_TYPE[5]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[5], Visible = true, IsDelete = false },
                new Product { ID = 96, Name = "Quần Ngắn QN014", Description = GetRandomDescription(PRODUCT_TYPE[5]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[5], Visible = true, IsDelete = false },
                new Product { ID = 97, Name = "Quần Ngắn QN015", Description = GetRandomDescription(PRODUCT_TYPE[5]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[5], Visible = true, IsDelete = false },
                new Product { ID = 98, Name = "Quần Ngắn QN016", Description = GetRandomDescription(PRODUCT_TYPE[5]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[5], Visible = true, IsDelete = false },
                new Product { ID = 99, Name = "Quần Ngắn QN017", Description = GetRandomDescription(PRODUCT_TYPE[5]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[5], Visible = true, IsDelete = false },
                new Product { ID = 100, Name = "Quần Ngắn QN018", Description = GetRandomDescription(PRODUCT_TYPE[5]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[5], Visible = true, IsDelete = false },
                new Product { ID = 101, Name = "Quần Ngắn QN019", Description = GetRandomDescription(PRODUCT_TYPE[5]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[5], Visible = true, IsDelete = false },
                new Product { ID = 102, Name = "Quần Ngắn QN020", Description = GetRandomDescription(PRODUCT_TYPE[5]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[5], Visible = true, IsDelete = false }
            );

            modelBuilder.Entity<Image>().HasData(
                ////Ao thun tay dai 1 - 19
                new Image { ID = 1, Name = "Ảnh minh hoạ D001", URL = "1_1_D001.jpg", ProductId = 1, IsDelete = false },
                new Image { ID = 2, Name = "Ảnh minh hoạ D001", URL = "1_2_D001.jpg", ProductId = 1, IsDelete = false },
                new Image { ID = 3, Name = "Ảnh minh hoạ D001", URL = "1_3_D001.jpg", ProductId = 1, IsDelete = false },
                new Image { ID = 4, Name = "Ảnh minh hoạ D001", URL = "1_4_D001.jpg", ProductId = 1, IsDelete = false },

                new Image { ID = 5, Name = "Ảnh minh hoạ D002", URL = "2_1_D002.jpg", ProductId = 2, IsDelete = false },
                new Image { ID = 6, Name = "Ảnh minh hoạ D002", URL = "2_2_D002.jpg", ProductId = 2, IsDelete = false },

                new Image { ID = 7, Name = "Ảnh minh hoạ D003", URL = "3_1_D003.jpg", ProductId = 3, IsDelete = false },
                new Image { ID = 8, Name = "Ảnh minh hoạ D003", URL = "3_2_D003.jpg", ProductId = 3, IsDelete = false },

                new Image { ID = 9, Name = "Ảnh minh hoạ D004", URL = "4_1_D004.jpg", ProductId = 4, IsDelete = false },
                new Image { ID = 10, Name = "Ảnh minh hoạ D004", URL = "4_2_D004.jpg", ProductId = 4, IsDelete = false },

                new Image { ID = 11, Name = "Ảnh minh hoạ D005", URL = "5_1_D005.jpg", ProductId = 5, IsDelete = false },
                new Image { ID = 12, Name = "Ảnh minh hoạ D005", URL = "5_2_D005.jpg", ProductId = 5, IsDelete = false },
                new Image { ID = 13, Name = "Ảnh minh hoạ D005", URL = "5_3_D005.jpg", ProductId = 5, IsDelete = false },

                new Image { ID = 14, Name = "Ảnh minh hoạ D006", URL = "6_1_D006.jpg", ProductId = 6, IsDelete = false },
                new Image { ID = 15, Name = "Ảnh minh hoạ D006", URL = "6_2_D006.jpg", ProductId = 6, IsDelete = false },
                new Image { ID = 16, Name = "Ảnh minh hoạ D006", URL = "6_3_D006.jpg", ProductId = 6, IsDelete = false },

                new Image { ID = 17, Name = "Ảnh minh hoạ D007", URL = "7_1_D007.jpg", ProductId = 7, IsDelete = false },
                new Image { ID = 18, Name = "Ảnh minh hoạ D007", URL = "7_2_D007.jpg", ProductId = 7, IsDelete = false },

                new Image { ID = 19, Name = "Ảnh minh hoạ D008", URL = "8_1_D008.jpg", ProductId = 8, IsDelete = false },
                new Image { ID = 20, Name = "Ảnh minh hoạ D008", URL = "8_2_D008.jpg", ProductId = 8, IsDelete = false },
                new Image { ID = 21, Name = "Ảnh minh hoạ D008", URL = "8_3_D008.jpg", ProductId = 8, IsDelete = false },

                new Image { ID = 22, Name = "Ảnh minh hoạ D009", URL = "9_1_D009.jpg", ProductId = 9, IsDelete = false },
                new Image { ID = 23, Name = "Ảnh minh hoạ D009", URL = "9_2_D009.jpg", ProductId = 9, IsDelete = false },

                new Image { ID = 24, Name = "Ảnh minh hoạ D010", URL = "10_1_D010.jpg", ProductId = 10, IsDelete = false },
                new Image { ID = 25, Name = "Ảnh minh hoạ D011", URL = "11_1_D011.jpg", ProductId = 11, IsDelete = false },
                new Image { ID = 26, Name = "Ảnh minh hoạ D012", URL = "12_1_D012.jpg", ProductId = 12, IsDelete = false },
                new Image { ID = 27, Name = "Ảnh minh hoạ D013", URL = "13_1_D013.jpg", ProductId = 13, IsDelete = false },
                new Image { ID = 28, Name = "Ảnh minh hoạ D014", URL = "14_1_D014.jpg", ProductId = 14, IsDelete = false },
                new Image { ID = 29, Name = "Ảnh minh hoạ D015", URL = "15_1_D015.jpg", ProductId = 15, IsDelete = false },
                new Image { ID = 30, Name = "Ảnh minh hoạ D016", URL = "16_1_D016.jpg", ProductId = 16, IsDelete = false },
                new Image { ID = 31, Name = "Ảnh minh hoạ D017", URL = "17_1_D017.jpg", ProductId = 17, IsDelete = false },
                new Image { ID = 32, Name = "Ảnh minh hoạ D018", URL = "18_1_D018.jpg", ProductId = 18, IsDelete = false },
                new Image { ID = 33, Name = "Ảnh minh hoạ D019", URL = "19_1_D019.jpg", ProductId = 19, IsDelete = false },

                //Ao thun tay dai 20 - 38
                new Image { ID = 34, Name = "Ảnh minh hoạ N001", URL = "20_1_N001.jpg", ProductId = 20, IsDelete = false },
                new Image { ID = 35, Name = "Ảnh minh hoạ N001", URL = "20_2_N001.jpg", ProductId = 20, IsDelete = false },
                new Image { ID = 36, Name = "Ảnh minh hoạ N001", URL = "20_3_N001.jpg", ProductId = 20, IsDelete = false },

                new Image { ID = 37, Name = "Ảnh minh hoạ N002", URL = "21_1_N002.jpg", ProductId = 21, IsDelete = false },
                new Image { ID = 38, Name = "Ảnh minh hoạ N002", URL = "21_2_N002.jpg", ProductId = 21, IsDelete = false },

                new Image { ID = 39, Name = "Ảnh minh hoạ N003", URL = "22_1_N003.jpg", ProductId = 22, IsDelete = false },
                new Image { ID = 41, Name = "Ảnh minh hoạ N003", URL = "22_2_N003.jpg", ProductId = 22, IsDelete = false },
                new Image { ID = 42, Name = "Ảnh minh hoạ N003", URL = "22_3_N003.jpg", ProductId = 22, IsDelete = false },

                new Image { ID = 43, Name = "Ảnh minh hoạ N004", URL = "23_1_N004.jpg", ProductId = 23, IsDelete = false },
                new Image { ID = 44, Name = "Ảnh minh hoạ N005", URL = "24_1_N005.jpg", ProductId = 24, IsDelete = false },
                new Image { ID = 45, Name = "Ảnh minh hoạ N006", URL = "25_1_N006.jpg", ProductId = 25, IsDelete = false },
                new Image { ID = 46, Name = "Ảnh minh hoạ N007", URL = "26_1_N007.jpg", ProductId = 26, IsDelete = false },
                new Image { ID = 47, Name = "Ảnh minh hoạ N008", URL = "27_1_N008.jpg", ProductId = 27, IsDelete = false },
                new Image { ID = 48, Name = "Ảnh minh hoạ N009", URL = "28_1_N009.jpg", ProductId = 28, IsDelete = false },
                new Image { ID = 49, Name = "Ảnh minh hoạ N010", URL = "29_1_N010.jpg", ProductId = 29, IsDelete = false },
                new Image { ID = 50, Name = "Ảnh minh hoạ N011", URL = "30_1_N011.jpg", ProductId = 30, IsDelete = false },
                new Image { ID = 51, Name = "Ảnh minh hoạ N012", URL = "31_1_N012.jpg", ProductId = 31, IsDelete = false },
                new Image { ID = 52, Name = "Ảnh minh hoạ N013", URL = "32_1_N013.jpg", ProductId = 32, IsDelete = false },
                new Image { ID = 53, Name = "Ảnh minh hoạ N014", URL = "33_1_N014.jpg", ProductId = 33, IsDelete = false },
                new Image { ID = 54, Name = "Ảnh minh hoạ N015", URL = "34_1_N015.jpg", ProductId = 34, IsDelete = false },
                new Image { ID = 55, Name = "Ảnh minh hoạ N016", URL = "35_1_N016.jpg", ProductId = 35, IsDelete = false },
                new Image { ID = 56, Name = "Ảnh minh hoạ N017", URL = "36_1_N017.jpg", ProductId = 36, IsDelete = false },
                new Image { ID = 57, Name = "Ảnh minh hoạ N018", URL = "37_1_N018.jpg", ProductId = 37, IsDelete = false },
                new Image { ID = 58, Name = "Ảnh minh hoạ N019", URL = "38_1_N019.jpg", ProductId = 38, IsDelete = false },

                //Ao so mi tay dai 39 - 49
                new Image { ID = 59, Name = "Ảnh minh hoạ D001", URL = "39_1_D001.jpg", ProductId = 39, IsDelete = false },
                new Image { ID = 60, Name = "Ảnh minh hoạ D001", URL = "39_2_D001.jpg", ProductId = 39, IsDelete = false },

                new Image { ID = 61, Name = "Ảnh minh hoạ D002", URL = "40_1_D002.jpg", ProductId = 40, IsDelete = false },
                new Image { ID = 62, Name = "Ảnh minh hoạ D002", URL = "40_2_D002.jpg", ProductId = 40, IsDelete = false },
                new Image { ID = 63, Name = "Ảnh minh hoạ D002", URL = "40_3_D002.jpg", ProductId = 40, IsDelete = false },
                new Image { ID = 64, Name = "Ảnh minh hoạ D002", URL = "40_4_D002.jpg", ProductId = 40, IsDelete = false },

                new Image { ID = 65, Name = "Ảnh minh hoạ D003", URL = "41_1_D003.jpg", ProductId = 41, IsDelete = false },
                new Image { ID = 66, Name = "Ảnh minh hoạ D003", URL = "41_2_D003.jpg", ProductId = 41, IsDelete = false },

                new Image { ID = 67, Name = "Ảnh minh hoạ D004", URL = "42_1_D004.jpg", ProductId = 42, IsDelete = false },
                new Image { ID = 68, Name = "Ảnh minh hoạ D004", URL = "42_2_D004.jpg", ProductId = 42, IsDelete = false },

                new Image { ID = 69, Name = "Ảnh minh hoạ D005", URL = "43_1_D005.jpg", ProductId = 43, IsDelete = false },
                new Image { ID = 70, Name = "Ảnh minh hoạ D006", URL = "44_1_D006.jpg", ProductId = 44, IsDelete = false },
                new Image { ID = 71, Name = "Ảnh minh hoạ D007", URL = "45_1_D007.jpg", ProductId = 45, IsDelete = false },
                new Image { ID = 72, Name = "Ảnh minh hoạ D008", URL = "46_1_D008.jpg", ProductId = 46, IsDelete = false },
                new Image { ID = 73, Name = "Ảnh minh hoạ D009", URL = "47_1_D009.jpg", ProductId = 47, IsDelete = false },
                new Image { ID = 74, Name = "Ảnh minh hoạ D010", URL = "48_1_D010.jpg", ProductId = 48, IsDelete = false },
                new Image { ID = 75, Name = "Ảnh minh hoạ D011", URL = "49_1_D011.jpg", ProductId = 49, IsDelete = false },

                //Ao so mi tay ngan 50 - 62
                new Image { ID = 76, Name = "Ảnh minh hoạ N001", URL = "50_1_N001.jpg", ProductId = 50, IsDelete = false },
                new Image { ID = 77, Name = "Ảnh minh hoạ N001", URL = "50_2_N001.jpg", ProductId = 50, IsDelete = false },
                new Image { ID = 78, Name = "Ảnh minh hoạ N001", URL = "50_3_N001.jpg", ProductId = 50, IsDelete = false },
                new Image { ID = 79, Name = "Ảnh minh hoạ N001", URL = "50_4_N001.jpg", ProductId = 50, IsDelete = false },

                new Image { ID = 80, Name = "Ảnh minh hoạ N002", URL = "51_1_N002.jpg", ProductId = 51, IsDelete = false },
                new Image { ID = 81, Name = "Ảnh minh hoạ N002", URL = "51_2_N002.jpg", ProductId = 51, IsDelete = false },
                new Image { ID = 82, Name = "Ảnh minh hoạ N002", URL = "51_3_N002.jpg", ProductId = 51, IsDelete = false },
                new Image { ID = 83, Name = "Ảnh minh hoạ N002", URL = "51_4_N002.jpg", ProductId = 51, IsDelete = false },

                new Image { ID = 84, Name = "Ảnh minh hoạ N003", URL = "52_1_N003.jpg", ProductId = 52, IsDelete = false },
                new Image { ID = 85, Name = "Ảnh minh hoạ N003", URL = "52_2_N003.jpg", ProductId = 52, IsDelete = false },
                new Image { ID = 86, Name = "Ảnh minh hoạ N003", URL = "52_3_N003.jpg", ProductId = 52, IsDelete = false },

                new Image { ID = 87, Name = "Ảnh minh hoạ N004", URL = "53_1_N004.jpg", ProductId = 53, IsDelete = false },
                new Image { ID = 88, Name = "Ảnh minh hoạ N005", URL = "54_1_N005.jpg", ProductId = 54, IsDelete = false },
                new Image { ID = 89, Name = "Ảnh minh hoạ N006", URL = "55_1_N006.jpg", ProductId = 55, IsDelete = false },
                new Image { ID = 90, Name = "Ảnh minh hoạ N007", URL = "56_1_N007.jpg", ProductId = 56, IsDelete = false },
                new Image { ID = 91, Name = "Ảnh minh hoạ N008", URL = "57_1_N008.jpg", ProductId = 57, IsDelete = false },
                new Image { ID = 92, Name = "Ảnh minh hoạ N009", URL = "58_1_N009.jpg", ProductId = 58, IsDelete = false },
                new Image { ID = 93, Name = "Ảnh minh hoạ N010", URL = "59_1_N010.jpg", ProductId = 59, IsDelete = false },
                new Image { ID = 94, Name = "Ảnh minh hoạ N011", URL = "60_1_N011.jpg", ProductId = 60, IsDelete = false },
                new Image { ID = 95, Name = "Ảnh minh hoạ N012", URL = "61_1_N012.jpg", ProductId = 61, IsDelete = false },
                new Image { ID = 96, Name = "Ảnh minh hoạ N013", URL = "62_1_N013.jpg", ProductId = 62, IsDelete = false },

                //Quan dai 63 - 82
                new Image { ID = 97, Name = "Ảnh minh hoạ QD001", URL = "63_1_QD001.jpg", ProductId = 63, IsDelete = false },
                new Image { ID = 98, Name = "Ảnh minh hoạ QD001", URL = "63_2_QD001.jpg", ProductId = 63, IsDelete = false },
                new Image { ID = 99, Name = "Ảnh minh hoạ QD001", URL = "63_3_QD001.jpg", ProductId = 63, IsDelete = false },

                new Image { ID = 100, Name = "Ảnh minh hoạ QD002", URL = "64_1_QD002.jpg", ProductId = 64, IsDelete = false },
                new Image { ID = 101, Name = "Ảnh minh hoạ QD002", URL = "64_2_QD002.jpg", ProductId = 64, IsDelete = false },
                new Image { ID = 102, Name = "Ảnh minh hoạ QD002", URL = "64_3_QD002.jpg", ProductId = 64, IsDelete = false },

                new Image { ID = 103, Name = "Ảnh minh hoạ QD003", URL = "65_1_QD003.jpg", ProductId = 65, IsDelete = false },
                new Image { ID = 104, Name = "Ảnh minh hoạ QD003", URL = "65_2_QD003.jpg", ProductId = 65, IsDelete = false },

                new Image { ID = 105, Name = "Ảnh minh hoạ QD004", URL = "66_1_QD004.jpg", ProductId = 66, IsDelete = false },
                new Image { ID = 106, Name = "Ảnh minh hoạ QD005", URL = "67_1_QD005.jpg", ProductId = 67, IsDelete = false },
                new Image { ID = 107, Name = "Ảnh minh hoạ QD006", URL = "68_1_QD006.jpg", ProductId = 68, IsDelete = false },
                new Image { ID = 108, Name = "Ảnh minh hoạ QD007", URL = "69_1_QD007.jpg", ProductId = 69, IsDelete = false },
                new Image { ID = 109, Name = "Ảnh minh hoạ QD008", URL = "70_1_QD008.jpg", ProductId = 70, IsDelete = false },
                new Image { ID = 110, Name = "Ảnh minh hoạ QD009", URL = "71_1_QD009.jpg", ProductId = 71, IsDelete = false },
                new Image { ID = 111, Name = "Ảnh minh hoạ QD010", URL = "72_1_QD010.jpg", ProductId = 72, IsDelete = false },
                new Image { ID = 112, Name = "Ảnh minh hoạ QD011", URL = "73_1_QD011.jpg", ProductId = 73, IsDelete = false },
                new Image { ID = 113, Name = "Ảnh minh hoạ QD012", URL = "74_1_QD012.jpg", ProductId = 74, IsDelete = false },
                new Image { ID = 114, Name = "Ảnh minh hoạ QD013", URL = "75_1_QD013.jpg", ProductId = 75, IsDelete = false },
                new Image { ID = 115, Name = "Ảnh minh hoạ QD014", URL = "76_1_QD014.jpg", ProductId = 76, IsDelete = false },
                new Image { ID = 116, Name = "Ảnh minh hoạ QD015", URL = "77_1_QD015.jpg", ProductId = 77, IsDelete = false },
                new Image { ID = 117, Name = "Ảnh minh hoạ QD016", URL = "78_1_QD016.jpg", ProductId = 78, IsDelete = false },
                new Image { ID = 118, Name = "Ảnh minh hoạ QD017", URL = "79_1_QD017.jpg", ProductId = 79, IsDelete = false },
                new Image { ID = 119, Name = "Ảnh minh hoạ QD018", URL = "80_1_QD018.jpg", ProductId = 80, IsDelete = false },
                new Image { ID = 120, Name = "Ảnh minh hoạ QD019", URL = "81_1_QD019.jpg", ProductId = 81, IsDelete = false },
                new Image { ID = 121, Name = "Ảnh minh hoạ QD020", URL = "82_1_QD020.jpg", ProductId = 82, IsDelete = false },

                //Quan ngan 83 - 102
                new Image { ID = 122, Name = "Ảnh minh hoạ QN001", URL = "83_1_QN001.jpg", ProductId = 83, IsDelete = false },
                new Image { ID = 123, Name = "Ảnh minh hoạ QN001", URL = "83_2_QN001.jpg", ProductId = 83, IsDelete = false },
                new Image { ID = 124, Name = "Ảnh minh hoạ QN001", URL = "83_3_QN001.jpg", ProductId = 83, IsDelete = false },
                new Image { ID = 125, Name = "Ảnh minh hoạ QN001", URL = "83_4_QN001.jpg", ProductId = 83, IsDelete = false },

                new Image { ID = 126, Name = "Ảnh minh hoạ QN002", URL = "84_1_QN002.jpg", ProductId = 84, IsDelete = false },
                new Image { ID = 127, Name = "Ảnh minh hoạ QN002", URL = "84_2_QN002.jpg", ProductId = 84, IsDelete = false },
                new Image { ID = 128, Name = "Ảnh minh hoạ QN002", URL = "84_3_QN002.jpg", ProductId = 84, IsDelete = false },

                new Image { ID = 129, Name = "Ảnh minh hoạ QN003", URL = "85_1_QN003.jpg", ProductId = 85, IsDelete = false },
                new Image { ID = 130, Name = "Ảnh minh hoạ QN003", URL = "85_2_QN003.jpg", ProductId = 85, IsDelete = false },
                new Image { ID = 131, Name = "Ảnh minh hoạ QN003", URL = "85_3_QN003.jpg", ProductId = 85, IsDelete = false },

                new Image { ID = 132, Name = "Ảnh minh hoạ QN004", URL = "86_1_QN004.jpg", ProductId = 86, IsDelete = false },
                new Image { ID = 133, Name = "Ảnh minh hoạ QN004", URL = "86_2_QN004.jpg", ProductId = 86, IsDelete = false },

                new Image { ID = 134, Name = "Ảnh minh hoạ QN005", URL = "87_1_QN005.jpg", ProductId = 87, IsDelete = false },
                new Image { ID = 135, Name = "Ảnh minh hoạ QN006", URL = "88_1_QN006.jpg", ProductId = 88, IsDelete = false },
                new Image { ID = 136, Name = "Ảnh minh hoạ QN007", URL = "89_1_QN007.jpg", ProductId = 89, IsDelete = false },
                new Image { ID = 137, Name = "Ảnh minh hoạ QN008", URL = "90_1_QN008.jpg", ProductId = 90, IsDelete = false },
                new Image { ID = 138, Name = "Ảnh minh hoạ QN009", URL = "91_1_QN009.jpg", ProductId = 91, IsDelete = false },
                new Image { ID = 139, Name = "Ảnh minh hoạ QN010", URL = "92_1_QN010.jpg", ProductId = 92, IsDelete = false },
                new Image { ID = 140, Name = "Ảnh minh hoạ QN011", URL = "93_1_QN011.jpg", ProductId = 93, IsDelete = false },
                new Image { ID = 141, Name = "Ảnh minh hoạ QN012", URL = "94_1_QN012.jpg", ProductId = 94, IsDelete = false },
                new Image { ID = 142, Name = "Ảnh minh hoạ QN013", URL = "95_1_QN013.jpg", ProductId = 95, IsDelete = false },
                new Image { ID = 143, Name = "Ảnh minh hoạ QN014", URL = "96_1_QN014.jpg", ProductId = 96, IsDelete = false },
                new Image { ID = 144, Name = "Ảnh minh hoạ QN015", URL = "97_1_QN015.jpg", ProductId = 97, IsDelete = false },
                new Image { ID = 145, Name = "Ảnh minh hoạ QN016", URL = "98_1_QN016.jpg", ProductId = 98, IsDelete = false },
                new Image { ID = 146, Name = "Ảnh minh hoạ QN017", URL = "99_1_QN017.jpg", ProductId = 99, IsDelete = false },
                new Image { ID = 147, Name = "Ảnh minh hoạ QN018", URL = "100_1_QN018.jpg", ProductId = 100, IsDelete = false },
                new Image { ID = 148, Name = "Ảnh minh hoạ QN019", URL = "101_1_QN019.jpg", ProductId = 101, IsDelete = false },
                new Image { ID = 149, Name = "Ảnh minh hoạ QN020", URL = "102_1_QN020.jpg", ProductId = 102, IsDelete = false }
            );

            modelBuilder.Entity<Warehouse>().HasData(
                new Warehouse { ID = 1, Size = "M", Color = "Xanh", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 1 },
                new Warehouse { ID = 2, Size = "M", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 1 },
                new Warehouse { ID = 3, Size = "L", Color = "Xanh", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 1 },
                new Warehouse { ID = 4, Size = "L", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 1 },
                new Warehouse { ID = 5, Size = "XL", Color = "Xanh", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 1 },
                new Warehouse { ID = 6, Size = "XL", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 1 }
            );

            
        }

        private static string GetRandomDescription(string type)
        {
            List<string> MO_TA_THUN_TAY_NGAN = new List<string>()
            {
                "T-Shirt Cotton Compact Premium là sản phẩm áo thun hoàn toàn mới với nhiều sự cải tiến đã được nghiên cứu kỹ lưỡng và phát triển với chất liệu Cotton Compact cao cấp. Một chiếc áo nên có trong tủ đồ với sự đa dụng dùng được trong mọi hoàn cảnh: đi làm, đi chơi, cafe hay cả những buổi gặp mặt lịch sự thì T-Shirt Coolmate chắc chắn sẽ làm bạn trên cả sự hài lòng. Đơn giản nhưng cực nam tính, đơn điệu mà vẫn thời thượng",
                "Vẫn là những chiếc áo với chật liệu Cotton 100% USA đã làm siêu lòng bao nhiêu khách hàng với những ưu điểm đặc biệt. Coolmate hiểu rằng, bạn không chỉ mong muốn có những chiếc áo thun trơn mà thêm những chiếc áo mang nhiều màu sắc, thiết kế mới mẻ mà vẫn tinh tế và đa dụng. Vì vậy, T-Shirt Pocket Tee ra đời với điểm nhấn là một chiếc túi nhỏ thiết kế trước ngực cùng sự tinh chỉnh thêm một số chi tiết nhỏ khác chắc chắn sẽ làm bạn hài lòng.",
                "Áo thun nam Essential Tee này đúng với tên của nó - một chiếc áo luôn cần có trong tủ đồ của bạn bởi sự tiện lợi, dễ mặc và dễ phối đồ trong bất kỳ trường hợp nào. Nếu một ngày bạn đang không biết mặc gì thì chọn ngay Essential Tee - tiện lợi ra đường, thoải mái mà lịch sự,... một chiếc áo đi từ nhà ra phố mà Coolmate dành rất nhiều thời gian để nghiên cứu và phát triển. Essential Tee được Coolmate đặt với mong muốn chiếc áo này sẽ làm đúng với cái tên của nó, chiếc áo đem lại trải nghiệm tốt nhất để ai cũng muốn sở hữu nó trong tủ đồ."
            };

            List<string> MO_TA_THUN_TAY_DAI = new List<string>()
            {
                "Bạn có đang tìm kiếm cho mình một một chiếc áo dài tay ấm áp. Coolmate hiểu được điều đó và đã nghiên cứu để gửi đến bạn một chiếc áo Sweatshirt với thiết kế vừa vặn, vô cùng thoải mái với chất liệu đặc biệt mềm mại. Và đó chính là áo nam Casual Sweatshirt - hoàn hảo cho những ngày thoải mái ở nhà, nhưng đủ tự tin để dạo phố cùng bạn bè.",
                "Rất nhiều thời gian và công sức để nghiên cứu và phát triển một sản phẩm, thay vì những vải lót bông bình thường dễ bị xù hoặc rụng bông nhỏ trong quá trình giặt và sử dụng, Coolmate lựa chọn chất liệu là 90% Cotton giúp chiếc áo của bạn vẫn thoát mồ hôi mà không hề gây bí, khó chịu; kết hợp với 10% Polyester giúp áo không nhăn và luôn bền dù có giặt, sấy bằng máy.",
                "Một chiếc áo vẫn giữ những vẻ thoải mái từ áo thun dài tay với chất kiệu Cotton Compact, chiếc áo vẫn mang cho bạn vẻ thanh lịch, nam tính mà chỉ có thể tìm thấy ở kiểu dáng polo. Và chiếc áo dài tay Prime Henley chính là item Coolmate dành cho bạn bởi Coolmate tin rằng đây nhất định là một chiếc áo bạn phải có trong tủ đồ của mình."
            };

            List<string> MO_TA_SO_MI = new List<string>()
            {
                "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu modal (gỗ sồi), sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo sơ mi Modal này có gì đặc biệt nhé!",
                "Với mỗi dòng sản phẩm chúng tôi đều mong muốn mang đến cho khách hàng nhiều sự lựa chọn và những cải tiến cùng công nghệ tốt nhất, đó là lý do Coolmate giới thiệu đến bạn những chiếc áo sơ mi chất liệu bamboo (vải tre) Ex-Soft này, sẽ mang đến cho khách hàng những trải nghiệm mới mẻ hơn. Cùng tìm hiểu những chiếc áo bamboo này có gì đặc biệt nhé!",
                "Áo sơ mi là một trong những sản phẩm tối quan trọng không thể thiếu trong tủ đồ của các chàng trai, Coolmate hiểu bạn cần một chiếc áo sơ mi basic đủ tốt được dùng trong những dịp quan trọng để mình trông lịch sự hơn, mặc sơ mi khi đi làm, áo sơ mi cũng dành cho những buổi đi chơi với nửa còn lại,... Sau 3 tháng nghiên cứu và phát triển sản phẩm, Coolmate cuối cùng đã cho ra mắt chiếc áo sơ mi đơn giản phù hợp với mọi dịp mà đạt đến độ chỉn chu từ những chi tiết nhỏ nhất."
            };

            List<string> MO_TA_QUAN = new List<string>()
            {
                "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái trong mọi vận động. Và Coolmate đặc biệt cho ra mắt sản phẩm Quần phiên bản mới với chất liệu vải 100% Polyester PTT đặc biệt CO GIÃN TUYỆT VỜI đem đến sự thoải mái tối đa.",
                "Ô! Nếu bạn đang tìm kiếm một chiếc quần vừa vặn, thoải mái, trẻ trung cùng mức giá hợp lý, thì đây là lựa chọn rất đáng để thử. Hơn 1 năm phát triển sản phẩm, Coolmate tự hào giới thiệu đến bạn chiếc quần đầu tiên của Coolmate với dáng Slim Fit với 3 màu dễ mặc dễ phối với những món đồ có sẵn trong tủ đồ nhà bạn.",
                "Lắng nghe khách hàng của mình và hiểu được mỗi chàng trai đều cần có trong tủ đồ mình 1 chiếc quần đặc biệt thoải mái với chất liệu 90% Cotton, 10% Polyester, giúp bạn luôn thoáng không gây bí, khó chịu."
            };

            Random rnd = new Random();
            int index = rnd.Next(0, 2);

            

            switch (type)
            {
                case "Áo thun tay dài":
                    return MO_TA_THUN_TAY_DAI[index];
                case "Áo thun tay ngắn":
                    return MO_TA_THUN_TAY_NGAN[index];
                case "Áo sơ mi tay dài":
                case "Áo sơ mi tay ngắn":
                    return MO_TA_SO_MI[index];
                case "Quần dài":
                case "Quần ngắn":
                    return MO_TA_QUAN[index];
                default:
                    return "";
            }
        }

        private static int GetRandomPrice()
        {
            List<int> PRICES = new List<int>()
            {
                199000, 230000, 149000, 469000, 399000, 299000, 499000, 259000, 359000
            };

            Random rnd = new Random();
            int index = rnd.Next(0, 2);

            return PRICES[index];
        }
    }
}
