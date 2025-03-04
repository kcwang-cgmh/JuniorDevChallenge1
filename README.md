﻿# 🎯 JuniorDevChallenge1：重構不良程式碼

## 📌 目標
這個程式允許使用者輸入學生姓名與成績，但它充滿了程式新手的錯誤。請試著發掘問題並重構，使其變得更具結構性、可讀性與效能提升。

## 🛠️ 作業指示
1. 下載這個專案，檢視 `Program.cs` 中的程式碼。
2. 發掘並修正錯誤，使程式變得更好。
3. 重新執行，確保程式能夠正確處理各種輸入情況。

## 🚀 重構步驟
1. 調整變數名稱，使其更具描述性。
2. 建立 Student 類別，用來儲存學生姓名與成績，避免資料結構分散。
3. 把資料輸入和成績顯示拆分成兩個方法，提高程式可讀性。
4. 重構 GetStudentData() 方法，加入成績輸入驗證。
5. 重構 DisplayGrades() 方法，簡化邏輯判斷。
6. 依循單一職責原則，將學生資料輸入與成績顯示處理拆分並封裝成兩個服務類別。