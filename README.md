# Bài tập rèn luyện 20 - Quản Lý Điểm - Lớp C Sharp nâng cao thầy Duy Thanh
## 1. Giới thiệu
Chương trình cho phép người dùng nhập điểm của sinh viên ứng với từng lớp học và môn học khác nhau.

Tác giả: Mai Quốc Dũng

Liên hệ: maiquocdung95@gmail.com

## 2. Mô tả phần mềm
### 2.1 Dữ liệu
Dữ liệu của Trường Đại Học (trung tâm,...) sẽ được lưu trong MS SQL.
Các bảng:
![image](https://user-images.githubusercontent.com/94212972/159919884-9d588ba2-342a-488a-a36c-39820d88a0c7.png)

Sơ đồ quan hệ:

![image](https://user-images.githubusercontent.com/94212972/159924183-4b7b70cf-3d39-4f77-9609-ac2b690a71e6.png)

### 2.2 Giao diện

![image](https://user-images.githubusercontent.com/94212972/159921356-aba59bea-7b7b-4db7-9558-f6f2e43ce047.png)

### 2.3 Mô tả sơ lượt giải thuật và cách sử dụng phần mềm.
Khi chương trình được mở lên, chương trình sẽ đọc dữ liệu từ bảng MonHoc và LopHoc, đưa vào ComboBox Môn học và Lớp Học.

Người dùng chọn Môn học và Lớp học xong bấm vào nút Nạp dữ liệu. Chương trình sẽ thực hiện lấy dữ liệu từ BangDiem ứng với Môn học và Lớp học đã chọn và hiển thị lên Gridview

Người dùng nhập điểm sau đó bấm nút Lưu điểm. Chương trình sẽ lấy dữ liệu điểm đã nhập và ghi vào BangDiem.

Lưu ý: Tải tệp CSDL về Attach vào SQL. Trong VS nhập chuỗi kết nối đến MS SQL của bạn vào để chương trình hoàn chỉnh.

![image](https://user-images.githubusercontent.com/94212972/159921008-d602e57d-b2b3-49e2-b055-df8241e37778.png)
