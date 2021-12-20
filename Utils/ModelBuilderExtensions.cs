using System;
using System.Collections.Generic;
using Clothing_Store.Models;
using Microsoft.EntityFrameworkCore;

namespace Clothing_Store.Utils
{
    public static class ModelBuilderExtensions
    {
        private static List<string> PRODUCT_TYPE = new List<string>() { "Áo thun tay dài", "Áo thun tay ngắn ", "Áo sơ mi tay dài", "Áo sơ mi tay ngắn", "Quần dài", "Quần ngắn" };
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
                new Product { ID = 1, Name = "Áo Thun D001", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 2, Name = "Áo Thun D002", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 3, Name = "Áo Thun D003", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 4, Name = "Áo Thun D004", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 5, Name = "Áo Thun D005", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 6, Name = "Áo Thun D006", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 7, Name = "Áo Thun D007", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 8, Name = "Áo Thun D008", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 9, Name = "Áo Thun D009", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 10, Name = "Áo Thun D010", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 11, Name = "Áo Thun D011", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 12, Name = "Áo Thun D012", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 13, Name = "Áo Thun D013", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 14, Name = "Áo Thun D014", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 15, Name = "Áo Thun D015", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 16, Name = "Áo Thun D016", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 17, Name = "Áo Thun D017", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 18, Name = "Áo Thun D018", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                new Product { ID = 19, Name = "Áo Thun D019", Description = GetRandomDescription(PRODUCT_TYPE[0]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[0], Visible = true, IsDelete = false },
                //Ao thun tay ngan
                new Product { ID = 20, Name = "Áo Thun N001", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 21, Name = "Áo Thun N002", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 22, Name = "Áo Thun N003", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 23, Name = "Áo Thun N004", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 24, Name = "Áo Thun N005", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 25, Name = "Áo Thun N006", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 26, Name = "Áo Thun N007", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 27, Name = "Áo Thun N008", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 28, Name = "Áo Thun N009", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 29, Name = "Áo Thun N010", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 30, Name = "Áo Thun N011", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 31, Name = "Áo Thun N012", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 32, Name = "Áo Thun N013", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 33, Name = "Áo Thun N014", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 34, Name = "Áo Thun N015", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 35, Name = "Áo Thun N016", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 36, Name = "Áo Thun N017", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 37, Name = "Áo Thun N018", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
                new Product { ID = 38, Name = "Áo Thun N019", Description = GetRandomDescription(PRODUCT_TYPE[1]), Price = GetRandomPrice(), ProductType = PRODUCT_TYPE[1], Visible = true, IsDelete = false },
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
                new Warehouse { ID = 1, Size = "M", Color = "Xanh dương", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 1 },
                new Warehouse { ID = 2, Size = "L", Color = "Xanh dương", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 1 },
                new Warehouse { ID = 3, Size = "XL", Color = "Xanh dương", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 1 },
                new Warehouse { ID = 4, Size = "M", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 1 },
                new Warehouse { ID = 5, Size = "L", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 1 },
                new Warehouse { ID = 6, Size = "XL", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 1 },

                new Warehouse { ID = 7, Size = "M", Color = "Xanh lá", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 2 },
                new Warehouse { ID = 8, Size = "L", Color = "Xanh lá", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 2 },
                new Warehouse { ID = 9, Size = "M", Color = "Đỏ", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 2 },
                new Warehouse { ID = 10, Size = "L", Color = "Đỏ", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 2 },

                new Warehouse { ID = 11, Size = "M", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 3 },
                new Warehouse { ID = 12, Size = "L", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 3 },
                new Warehouse { ID = 13, Size = "M", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 3 },
                new Warehouse { ID = 14, Size = "L", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 3 },

                new Warehouse { ID = 15, Size = "M", Color = "Vàng cam", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 4 },
                new Warehouse { ID = 16, Size = "L", Color = "Vàng cam", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 4 },
                new Warehouse { ID = 17, Size = "M", Color = "Xanh dương", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 4 },
                new Warehouse { ID = 18, Size = "L", Color = "Xanh dương", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 4 },

                new Warehouse { ID = 19, Size = "M", Color = "Đỏ", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 5 },
                new Warehouse { ID = 20, Size = "L", Color = "Đỏ", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 5 },
                new Warehouse { ID = 21, Size = "M", Color = "Vàng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 5 },
                new Warehouse { ID = 22, Size = "L", Color = "Vàng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 5 },

                new Warehouse { ID = 23, Size = "M", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 6 },
                new Warehouse { ID = 24, Size = "L", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 6 },
                new Warehouse { ID = 25, Size = "M", Color = "Đỏ", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 6 },
                new Warehouse { ID = 26, Size = "L", Color = "Đỏ", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 6 },
                new Warehouse { ID = 27, Size = "M", Color = "Vàng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 6 },
                new Warehouse { ID = 28, Size = "L", Color = "Vàng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 6 },

                new Warehouse { ID = 29, Size = "M", Color = "Xanh lá", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 7 },
                new Warehouse { ID = 30, Size = "L", Color = "Xanh lá", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 7 },
                new Warehouse { ID = 31, Size = "M", Color = "Xanh mint", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 7 },
                new Warehouse { ID = 32, Size = "L", Color = "Xanh mint", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 7 },

                new Warehouse { ID = 33, Size = "M", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 8 },
                new Warehouse { ID = 34, Size = "L", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 8 },
                new Warehouse { ID = 35, Size = "M", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 8 },
                new Warehouse { ID = 36, Size = "L", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 8 },
                new Warehouse { ID = 37, Size = "M", Color = "Xanh nhạt", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 8 },
                new Warehouse { ID = 38, Size = "L", Color = "Xanh nhạt", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 8 },

                new Warehouse { ID = 39, Size = "M", Color = "Xanh đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 9 },
                new Warehouse { ID = 40, Size = "L", Color = "Xanh đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 9 },
                new Warehouse { ID = 41, Size = "M", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 9 },
                new Warehouse { ID = 42, Size = "L", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 9 },

                new Warehouse { ID = 43, Size = "L", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 10 },
                new Warehouse { ID = 44, Size = "L", Color = "Xanh dương", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 11 },
                new Warehouse { ID = 45, Size = "L", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 12 },
                new Warehouse { ID = 46, Size = "L", Color = "Đỏ", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 13 },
                new Warehouse { ID = 47, Size = "L", Color = "Xanh đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 14 },
                new Warehouse { ID = 48, Size = "L", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 15 },
                new Warehouse { ID = 49, Size = "L", Color = "Xám", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 16 },
                new Warehouse { ID = 50, Size = "L", Color = "Xám", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 17 },
                new Warehouse { ID = 51, Size = "L", Color = "Xanh đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 18 },
                new Warehouse { ID = 52, Size = "L", Color = "Trắng vàng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 19 },
                
                new Warehouse { ID = 53, Size = "M", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 20 },
                new Warehouse { ID = 54, Size = "L", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 20 },
                new Warehouse { ID = 55, Size = "XL", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 20 },

                new Warehouse { ID = 56, Size = "M", Color = "Vàng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 21 },
                new Warehouse { ID = 57, Size = "L", Color = "Vàng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 21 },
                new Warehouse { ID = 58, Size = "M", Color = "Nâu nhạt", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 21 },
                new Warehouse { ID = 59, Size = "L", Color = "Nâu nhạt", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 21 },

                new Warehouse { ID = 60, Size = "M", Color = "Xám", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 22 },
                new Warehouse { ID = 61, Size = "L", Color = "Xám", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 22 },
                new Warehouse { ID = 62, Size = "M", Color = "Đỏ", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 22 },
                new Warehouse { ID = 63, Size = "L", Color = "Đỏ", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 22 },
                new Warehouse { ID = 64, Size = "M", Color = "Vàng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 22 },
                new Warehouse { ID = 65, Size = "L", Color = "Vàng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 22 },

                new Warehouse { ID = 66, Size = "M", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 23 },
                new Warehouse { ID = 67, Size = "L", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 23 },
                new Warehouse { ID = 68, Size = "M", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 23 },
                new Warehouse { ID = 69, Size = "L", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 23 },

                new Warehouse { ID = 70, Size = "M", Color = "Xanh rêu", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 24 },
                new Warehouse { ID = 71, Size = "L", Color = "Xanh rêu", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 24 },

                new Warehouse { ID = 72, Size = "M", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 25 },
                new Warehouse { ID = 73, Size = "L", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 25 },
                
                new Warehouse { ID = 74, Size = "L", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 26 },
                new Warehouse { ID = 75, Size = "L", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 27 },
                new Warehouse { ID = 76, Size = "L", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 28 },
                new Warehouse { ID = 77, Size = "L", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 29 },
                new Warehouse { ID = 78, Size = "L", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 30 },
                new Warehouse { ID = 79, Size = "L", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 31 },
                new Warehouse { ID = 80, Size = "L", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 32 },
                new Warehouse { ID = 81, Size = "L", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 33 },
                new Warehouse { ID = 82, Size = "L", Color = "Xám", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 34 },
                new Warehouse { ID = 83, Size = "L", Color = "Xanh đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 35 },
                new Warehouse { ID = 84, Size = "L", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 36 },
                new Warehouse { ID = 85, Size = "L", Color = "Xanh", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 37 },
                new Warehouse { ID = 86, Size = "L", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 38 },

                new Warehouse { ID = 87, Size = "M", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 39 },
                new Warehouse { ID = 88, Size = "L", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 39 },

                new Warehouse { ID = 89, Size = "M", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 40 },
                new Warehouse { ID = 90, Size = "L", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 40 },

                new Warehouse { ID = 91, Size = "M", Color = "Caro xanh", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 41 },
                new Warehouse { ID = 92, Size = "L", Color = "Caro xanh", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 41 },
                new Warehouse { ID = 93, Size = "M", Color = "Caro đỏ", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 41 },
                new Warehouse { ID = 94, Size = "L", Color = "Caro đỏ", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 41 },

                new Warehouse { ID = 95, Size = "M", Color = "Caro xám", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 42 },
                new Warehouse { ID = 96, Size = "L", Color = "Caro xám", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 42 },

                new Warehouse { ID = 97, Size = "L", Color = "Caro đỏ", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 43 },
                new Warehouse { ID = 98, Size = "L", Color = "Caro đỏ", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 44 },
                new Warehouse { ID = 99, Size = "L", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 45 },
                new Warehouse { ID = 100, Size = "L", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 46 },
                new Warehouse { ID = 101, Size = "M", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 47 },
                new Warehouse { ID = 102, Size = "L", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 47 },
                new Warehouse { ID = 103, Size = "M", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 47 },
                new Warehouse { ID = 104, Size = "L", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 47 },
                new Warehouse { ID = 105, Size = "L", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 48 },
                new Warehouse { ID = 106, Size = "L", Color = "Xanh biển", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 49 },

                new Warehouse { ID = 107, Size = "M", Color = "Xanh biển", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 50 },
                new Warehouse { ID = 108, Size = "L", Color = "Xanh biển", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 50 },
                new Warehouse { ID = 109, Size = "XL", Color = "Xanh biển", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 50 },

                new Warehouse { ID = 110, Size = "M", Color = "Caro cam", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 51 },
                new Warehouse { ID = 111, Size = "L", Color = "Caro cam", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 51 },
                new Warehouse { ID = 112, Size = "M", Color = "Caro xanh", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 51 },
                new Warehouse { ID = 113, Size = "L", Color = "Caro xanh", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 51 },

                new Warehouse { ID = 114, Size = "M", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 52 },
                new Warehouse { ID = 115, Size = "L", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 52 },
                new Warehouse { ID = 116, Size = "XL", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 52 },

                new Warehouse { ID = 117, Size = "L", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 53 },
                new Warehouse { ID = 118, Size = "L", Color = "Xanh biển", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 54 },
                new Warehouse { ID = 119, Size = "L", Color = "Hoạ tiết 1", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 55 },
                new Warehouse { ID = 120, Size = "L", Color = "Xanh biển", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 56 },
                new Warehouse { ID = 121, Size = "L", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 57 },
                new Warehouse { ID = 122, Size = "L", Color = "Xanh dương", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 58 },
                new Warehouse { ID = 123, Size = "L", Color = "Xanh biển", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 59 },
                new Warehouse { ID = 124, Size = "L", Color = "Nâu nhạt", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 60 },
                new Warehouse { ID = 125, Size = "L", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 61 },
                new Warehouse { ID = 126, Size = "L", Color = "Xanh biển", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 62 },

                new Warehouse { ID = 127, Size = "M", Color = "Đỏ", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 63 },
                new Warehouse { ID = 128, Size = "L", Color = "Đỏ", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 63 },
                new Warehouse { ID = 129, Size = "M", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 63 },
                new Warehouse { ID = 130, Size = "L", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 63 },

                new Warehouse { ID = 131, Size = "M", Color = "Đỏ", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 64 },
                new Warehouse { ID = 132, Size = "L", Color = "Đỏ", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 64 },

                new Warehouse { ID = 133, Size = "M", Color = "Xám", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 65 },
                new Warehouse { ID = 134, Size = "L", Color = "Xám", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 65 },
                new Warehouse { ID = 135, Size = "M", Color = "Vàng kem", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 65 },
                new Warehouse { ID = 136, Size = "L", Color = "Vàng kem", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 65 },

                new Warehouse { ID = 137, Size = "L", Color = "Đỏ", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 66 },
                new Warehouse { ID = 138, Size = "L", Color = "Vàng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 67 },
                new Warehouse { ID = 139, Size = "L", Color = "Xanh rêu", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 68 },
                new Warehouse { ID = 140, Size = "L", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 69 },
                new Warehouse { ID = 141, Size = "L", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 70 },
                new Warehouse { ID = 142, Size = "L", Color = "Đỏ", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 71 },
                new Warehouse { ID = 143, Size = "L", Color = "Xanh rêu", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 72 },
                new Warehouse { ID = 144, Size = "L", Color = "Vàng kem", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 73 },
                new Warehouse { ID = 145, Size = "L", Color = "Xám", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 74 },
                new Warehouse { ID = 146, Size = "L", Color = "Nâu", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 75 },
                new Warehouse { ID = 147, Size = "L", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 76 },
                new Warehouse { ID = 148, Size = "L", Color = "Xám", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 77 },
                new Warehouse { ID = 149, Size = "L", Color = "Đỏ", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 78 },
                new Warehouse { ID = 150, Size = "L", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 79 },
                new Warehouse { ID = 151, Size = "L", Color = "Xanh rêu", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 80 },
                new Warehouse { ID = 152, Size = "L", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 81 },
                new Warehouse { ID = 153, Size = "L", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 82 },

                new Warehouse { ID = 154, Size = "M", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 83 },
                new Warehouse { ID = 155, Size = "L", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 83 },

                new Warehouse { ID = 156, Size = "M", Color = "Xanh jean", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 84 },
                new Warehouse { ID = 157, Size = "L", Color = "Xanh jean", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 84 },

                new Warehouse { ID = 158, Size = "M", Color = "Xanh jean", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 85 },
                new Warehouse { ID = 159, Size = "L", Color = "Xanh jean", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 85 },

                new Warehouse { ID = 160, Size = "M", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 86 },
                new Warehouse { ID = 161, Size = "L", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 86 },

                new Warehouse { ID = 162, Size = "L", Color = "Xanh jean", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 87 },
                new Warehouse { ID = 163, Size = "L", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 88 },
                new Warehouse { ID = 164, Size = "L", Color = "Xám", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 89 },
                new Warehouse { ID = 165, Size = "L", Color = "Xám", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 90 },
                new Warehouse { ID = 166, Size = "L", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 91 },
                new Warehouse { ID = 167, Size = "L", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 92 },
                new Warehouse { ID = 168, Size = "L", Color = "Xám", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 93 },
                new Warehouse { ID = 169, Size = "L", Color = "Xám", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 94 },
                new Warehouse { ID = 170, Size = "L", Color = "Xanh rêu", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 95 },
                new Warehouse { ID = 171, Size = "L", Color = "Xám", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 96 },
                new Warehouse { ID = 172, Size = "L", Color = "Nâu nhạt", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 97 },
                new Warehouse { ID = 173, Size = "L", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 98 },
                new Warehouse { ID = 174, Size = "L", Color = "Xám jean", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 99 },
                new Warehouse { ID = 175, Size = "L", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 100 },
                new Warehouse { ID = 176, Size = "L", Color = "Trắng", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 101 },
                new Warehouse { ID = 177, Size = "L", Color = "Đen", Quantity = 100, Sold = 0, LastUpdate = DateTime.Now, ProductID = 102 }
            );

            modelBuilder.Entity<Promotion>().HasData(
                new Promotion { ID = 1, Name = "Sale cuối năm", Description = "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", Discount = 10, From = DateTime.Now, To = DateTime.Now.AddDays(40), ProductID = 1, Visible = true, IsDelete = false },
                new Promotion { ID = 2, Name = "Sale cuối năm", Description = "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", Discount = 20, From = DateTime.Now, To = DateTime.Now.AddDays(40), ProductID = 2, Visible = true, IsDelete = false },
                new Promotion { ID = 3, Name = "Sale cuối năm", Description = "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", Discount = 30, From = DateTime.Now, To = DateTime.Now.AddDays(40), ProductID = 3, Visible = true, IsDelete = false },
                new Promotion { ID = 4, Name = "Sale cuối năm", Description = "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", Discount = 20, From = DateTime.Now, To = DateTime.Now.AddDays(40), ProductID = 4, Visible = true, IsDelete = false },
                new Promotion { ID = 5, Name = "Sale cuối năm", Description = "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", Discount = 10, From = DateTime.Now, To = DateTime.Now.AddDays(40), ProductID = 5, Visible = true, IsDelete = false },
                new Promotion { ID = 6, Name = "Sale cuối năm", Description = "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", Discount = 10, From = DateTime.Now, To = DateTime.Now.AddDays(40), ProductID = 6, Visible = true, IsDelete = false },
                new Promotion { ID = 7, Name = "Sale cuối năm", Description = "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", Discount = 10, From = DateTime.Now, To = DateTime.Now.AddDays(40), ProductID = 20, Visible = true, IsDelete = false },
                new Promotion { ID = 8, Name = "Sale cuối năm", Description = "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", Discount = 50, From = DateTime.Now, To = DateTime.Now.AddDays(40), ProductID = 21, Visible = true, IsDelete = false },
                new Promotion { ID = 9, Name = "Sale cuối năm", Description = "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", Discount = 50, From = DateTime.Now, To = DateTime.Now.AddDays(40), ProductID = 22, Visible = true, IsDelete = false },
                new Promotion { ID = 10, Name = "Sale cuối năm", Description = "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", Discount = 10, From = DateTime.Now, To = DateTime.Now.AddDays(40), ProductID = 40, Visible = true, IsDelete = false },
                new Promotion { ID = 11, Name = "Sale cuối năm", Description = "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", Discount = 20, From = DateTime.Now, To = DateTime.Now.AddDays(40), ProductID = 41, Visible = true, IsDelete = false },
                new Promotion { ID = 12, Name = "Sale cuối năm", Description = "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", Discount = 20, From = DateTime.Now, To = DateTime.Now.AddDays(40), ProductID = 42, Visible = true, IsDelete = false },
                new Promotion { ID = 13, Name = "Sale cuối năm", Description = "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", Discount = 20, From = DateTime.Now, To = DateTime.Now.AddDays(40), ProductID = 50, Visible = true, IsDelete = false },
                new Promotion { ID = 14, Name = "Sale cuối năm", Description = "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", Discount = 50, From = DateTime.Now, To = DateTime.Now.AddDays(40), ProductID = 51, Visible = true, IsDelete = false },
                new Promotion { ID = 15, Name = "Sale cuối năm", Description = "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", Discount = 40, From = DateTime.Now, To = DateTime.Now.AddDays(40), ProductID = 52, Visible = true, IsDelete = false },
                new Promotion { ID = 16, Name = "Sale cuối năm", Description = "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", Discount = 40, From = DateTime.Now, To = DateTime.Now.AddDays(40), ProductID = 63, Visible = true, IsDelete = false },
                new Promotion { ID = 17, Name = "Sale cuối năm", Description = "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", Discount = 30, From = DateTime.Now, To = DateTime.Now.AddDays(40), ProductID = 64, Visible = true, IsDelete = false },
                new Promotion { ID = 18, Name = "Sale cuối năm", Description = "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", Discount = 30, From = DateTime.Now, To = DateTime.Now.AddDays(40), ProductID = 65, Visible = true, IsDelete = false },
                new Promotion { ID = 19, Name = "Sale cuối năm", Description = "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", Discount = 10, From = DateTime.Now, To = DateTime.Now.AddDays(40), ProductID = 83, Visible = true, IsDelete = false },
                new Promotion { ID = 20, Name = "Sale cuối năm", Description = "Giảm giá cực sốc từ 10% đến 50% nhân dịp cuối năm", Discount = 10, From = DateTime.Now, To = DateTime.Now.AddDays(40), ProductID = 85, Visible = true, IsDelete = false }
            );

            modelBuilder.Entity<Account>().HasData(
                new Account { ID = 1, Username = "vidiec", Password = "$2a$11$/VFMOT9NcFNk1NmgvPTL/OJ7gpBru8bSoT6XjDiAF2xIEMb6lsTbi", Email = "diecluchivi2701@gmail.com", IsDelete = false },
                new Account { ID = 2, Username = "phutang", Password = "$2a$11$/VFMOT9NcFNk1NmgvPTL/OJ7gpBru8bSoT6XjDiAF2xIEMb6lsTbi", Email = "camphu480@gmail.com", IsDelete = false },
                new Account { ID = 3, Username = "trannguyen", Password = "$2a$11$/VFMOT9NcFNk1NmgvPTL/OJ7gpBru8bSoT6XjDiAF2xIEMb6lsTbi", Email = "trannguyen@student.tdtu.edu.vn", IsDelete = false },
                new Account { ID = 4, Username = "hongtran", Password = "$2a$11$/VFMOT9NcFNk1NmgvPTL/OJ7gpBru8bSoT6XjDiAF2xIEMb6lsTbi", Email = "hongtran@student.tdtu.edu.vn", IsDelete = false },
                new Account { ID = 5, Username = "nhily", Password = "$2a$11$/VFMOT9NcFNk1NmgvPTL/OJ7gpBru8bSoT6XjDiAF2xIEMb6lsTbi", Email = "nhily@student.tdtu.edu.vn", IsDelete = false },
                new Account { ID = 6, Username = "quynhha", Password = "$2a$11$/VFMOT9NcFNk1NmgvPTL/OJ7gpBru8bSoT6XjDiAF2xIEMb6lsTbi", Email = "quynhha@student.tdtu.edu.vn", IsDelete = false },
                new Account { ID = 7, Username = "huyhuy", Password = "$2a$11$/VFMOT9NcFNk1NmgvPTL/OJ7gpBru8bSoT6XjDiAF2xIEMb6lsTbi", Email = "huyhuy@student.tdtu.edu.vn", IsDelete = false },
                new Account { ID = 8, Username = "thanhthanh", Password = "$2a$11$/VFMOT9NcFNk1NmgvPTL/OJ7gpBru8bSoT6XjDiAF2xIEMb6lsTbi", Email = "thanhthanh@student.tdtu.edu.vn", IsDelete = false },
                new Account { ID = 9, Username = "tungtran", Password = "$2a$11$/VFMOT9NcFNk1NmgvPTL/OJ7gpBru8bSoT6XjDiAF2xIEMb6lsTbi", Email = "tungtran@student.tdtu.edu.vn", IsDelete = false },
                new Account { ID = 10, Username = "huytran", Password = "$2a$11$/VFMOT9NcFNk1NmgvPTL/OJ7gpBru8bSoT6XjDiAF2xIEMb6lsTbi", Email = "huytran@student.tdtu.edu.vn", IsDelete = false },
                new Account { ID = 11, Username = "huyhua", Password = "$2a$11$/VFMOT9NcFNk1NmgvPTL/OJ7gpBru8bSoT6XjDiAF2xIEMb6lsTbi", Email = "huyhua@student.tdtu.edu.vn", IsDelete = false },
                new Account { ID = 12, Username = "khoidang", Password = "$2a$11$/VFMOT9NcFNk1NmgvPTL/OJ7gpBru8bSoT6XjDiAF2xIEMb6lsTbi", Email = "khoidang@student.tdtu.edu.vn", IsDelete = false },
                new Account { ID = 13, Username = "admin1", Password = "$2a$11$/VFMOT9NcFNk1NmgvPTL/OJ7gpBru8bSoT6XjDiAF2xIEMb6lsTbi", Email = "admin1@coolmate.edu.vn", IsDelete = false },
                new Account { ID = 14, Username = "admin2", Password = "$2a$11$/VFMOT9NcFNk1NmgvPTL/OJ7gpBru8bSoT6XjDiAF2xIEMb6lsTbi", Email = "admin2@coolmate.edu.vn", IsDelete = false },
                new Account { ID = 15, Username = "admin3", Password = "$2a$11$/VFMOT9NcFNk1NmgvPTL/OJ7gpBru8bSoT6XjDiAF2xIEMb6lsTbi", Email = "admin3@coolmate.edu.vn", IsDelete = false }
            );

            modelBuilder.Entity<Customer>().HasData(
                new Customer { ID = 1, Fullname = "Diệc Lữ Chí Vĩ", Phone = "0909010003", Address = "12 Nguyễn Huệ P.Bến Nghé Q.1", CardNumber = "271119473238", ValidDate = DateTime.Now.AddYears(2), SecretNumber = "2986361", AccountID = 1},
                new Customer { ID = 2, Fullname = "Tăng Cẩm Phú", Phone = "0909110203", Address = "12 Nguyễn Huệ P.Bến Nghé Q.2", CardNumber = "274611273238", ValidDate = DateTime.Now.AddYears(1), SecretNumber = "2916361", AccountID = 2},
                new Customer { ID = 3, Fullname = "Nguyễn Trân", Phone = "0909020203", Address = "12 Nguyễn Huệ P.Bến Nghé Q.3", CardNumber = "274621133238", ValidDate = DateTime.Now.AddYears(2), SecretNumber = "2982360", AccountID = 3},
                new Customer { ID = 4, Fullname = "Trần Hồng", Phone = "0909010303", Address = "12 Nguyễn Huệ P.Bến Nghé Q.4", CardNumber = "274629411438", ValidDate = DateTime.Now.AddYears(2), SecretNumber = "2986331", AccountID = 4},
                new Customer { ID = 5, Fullname = "Nhi Lý", Phone = "0909610203", Address = "12 Nguyễn Huệ P.Bến Nghé Q.5", CardNumber = "115629473238", ValidDate = DateTime.Now.AddYears(2), SecretNumber = "2986364", AccountID = 5},
                new Customer { ID = 6, Fullname = "Hà Quỳnh", Phone = "0989010203", Address = "12 Nguyễn Huệ P.Bến Nghé Q.6", CardNumber = "116629473238", ValidDate = DateTime.Now.AddYears(1), SecretNumber = "2986661", AccountID = 6},
                new Customer { ID = 7, Fullname = "Huy Huy", Phone = "0909010203", Address = "12 Nguyễn Huệ P.Bến Nghé Q.7", CardNumber = "211729473238", ValidDate = DateTime.Now.AddYears(1), SecretNumber = "2986371", AccountID = 7},
                new Customer { ID = 8, Fullname = "Thanh Thanh", Phone = "0309010203", Address = "12 Nguyễn Huệ P.Bến Nghé Q.8", CardNumber = "118629473238", ValidDate = DateTime.Now.AddYears(1), SecretNumber = "2886361", AccountID = 8},
                new Customer { ID = 9, Fullname = "Tùng Trần", Phone = "0904010203", Address = "12 Nguyễn Huệ P.Bến Nghé Q.9", CardNumber = "271199473238", ValidDate = DateTime.Now.AddYears(1), SecretNumber = "2989361", AccountID = 9},
                new Customer { ID = 10, Fullname = "Trần Huy", Phone = "0908010203", Address = "12 Nguyễn Huệ P.Bến Nghé Q.10", CardNumber = "212029473238", ValidDate = DateTime.Now.AddYears(1), SecretNumber = "2196361", AccountID = 10},
                new Customer { ID = 11, Fullname = "Hứa Huy", Phone = "0900010203", Address = "12 Nguyễn Huệ P.Bến Nghé Q.11", CardNumber = "271219473238", ValidDate = DateTime.Now.AddYears(2), SecretNumber = "2982361", AccountID = 11},
                new Customer { ID = 12, Fullname = "Đặng Khôi", Phone = "0990210203", Address = "12 Nguyễn Huệ P.Bến Nghé Q.12", CardNumber = "274612273238", ValidDate = DateTime.Now.AddYears(2), SecretNumber = "2186361", AccountID = 12}
            );

            modelBuilder.Entity<Admin>().HasData(
                new Admin { ID = 1, Fullname = "Doãn Xuân Thanh", Phone = "0902228888", AccountID = 13 },
                new Admin { ID = 2, Fullname = "Nguyễn Thành Nhân", Phone = "0903338888", AccountID = 14 },
                new Admin { ID = 3, Fullname = "Đặng Kim Thư", Phone = "0904448888", AccountID = 15 }
            );

            modelBuilder.Entity<CartDetails>().HasData(
                new CartDetails { ID = 1, Size = "M", Color = "Đỏ", Quantity = 2, accountID = 1, productID = 5, IsSelected = true, IsDelete = false },
                new CartDetails { ID = 2, Size = "L", Color = "Xanh mint", Quantity = 1, accountID = 1, productID = 7, IsSelected = true, IsDelete = false },
                new CartDetails { ID = 3, Size = "L", Color = "Đen", Quantity = 3, accountID = 1, productID = 26, IsSelected = false, IsDelete = false },
                new CartDetails { ID = 4, Size = "M", Color = "Trắng", Quantity = 2, accountID = 1, productID = 25, IsSelected = true, IsDelete = false },
                new CartDetails { ID = 5, Size = "L", Color = "Trắng", Quantity = 1, accountID = 1, productID = 52, IsSelected = true, IsDelete = false },
                new CartDetails { ID = 6, Size = "L", Color = "Vàng", Quantity = 1, accountID = 2, productID = 5, IsSelected = true, IsDelete = false },
                new CartDetails { ID = 7, Size = "L", Color = "Xám", Quantity = 4, accountID = 2, productID = 74, IsSelected = false, IsDelete = false },
                new CartDetails { ID = 8, Size = "L", Color = "Đen", Quantity = 2, accountID = 2, productID = 88, IsSelected = true, IsDelete = false },
                new CartDetails { ID = 9, Size = "M", Color = "Đen", Quantity = 2, accountID = 2, productID = 83, IsSelected = true, IsDelete = false },
                new CartDetails { ID = 10, Size = "M", Color = "Xanh jean", Quantity = 1, accountID = 2, productID = 85, IsSelected = true, IsDelete = false }
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
                case "Áo Thun tay ngắn":
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
