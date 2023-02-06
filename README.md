# An toàn bảo mật trong hệ thống thông tin
Đồ án thực hành môn an toàn và bảo mật dữ liệu trong hệ thống thông tin

Giao diện Winform
Oracle/plsql
VPD, Audit, mã hóa, DAC - RBAC

PHÂN HỆ 1: DÀNH CHO NGƯỜI QUẢN TRỊ CƠ SỞ DỮ LIỆU
- Xem danh sách người dùng trong hệ thống.
- Thông tin về quyền (privileges) của mỗi user/ role trên các đối tượng dữ liệu.
- Cho phép tạo mới, xóa, sửa (hiệu chỉnh) user hoặc role.
- Cho phép thực hiện việc cấp quyền: cấp quyền cho user, cấp quyền cho role, 
cấp role cho user. Quá trình cấp quyền có tùy chọn là có cho phép người được 
cấp quyền có thể cấp quyền đó cho user/ role khác hay không (có chỉ định WITH 
GRANT OPTION hay không). Quyền, select, update thì cho phép phân quyền 
tinh đến mức cột; quyền insert, delete thì không.
- Cho phép thu hồi quyền từ người dùng/ role.
- Cho phép kiểm tra quyền của các chủ thể vừa được cấp quyền.
- Cho phép chỉnh sửa quyền của user/ role.
PHÂN HỆ 2: Sở y tế tỉnh/ thành phố X cần gom dữ liệu về kho dữ liệu D (cấp sở), gồm 
hồ sơ bệnh án (và một số dữ liệu liên quan) từ các cơ sở y tế trong tỉnh/ thành phố và 
quản lý chuyên môn về việc khám chữa bệnh của các cơ sở y tế thông qua một hệ thống 
thông tin quản lý S. 
