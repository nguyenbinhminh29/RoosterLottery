# RoosterLottery

## Hướng dẫn cài đặt Database

Bạn có thể dùng file backup ZLR_DEV.bak để restore database, hoặc dùng file script SQLQueryLottery.sql để tạo Database bằng script.
Sau khi có Database thì dùng script trong file SQLQueryLotteryJob.sql để chạy job cho app. Mục đích là định kỳ chạy storeprocedure để tạo xổ số.

## Hướng dẫn Cách chạy app

Bộ app có 3 phần: Server (API), Client và ClientMonitor (Application)

- Đối với Server API, giải nén file Server.rar và deploy lên IIS. Lưu ý, trước khi run, hãy điền chuỗi connect đến SQL Server vào file appsettings.json ở thẻ DefaultConnection.
- Đối với app Client, giải nén file Client.rar và run file Client.exe. Lưu ý, mặc định app sẽ connect đến địa chỉ API là https://localhost:7266/, nếu có thay đổi thì hãy mở file Client.dll.config và sửa trong thẻ appSettings, value của với key ServerAddress.
- Đối với app ClientMonitor, giải nén ClientMonitor.rar và run file ClientMonitoring.exe. Mặc định app sẽ connect đến địa chỉ API là https://localhost:7266/, nếu có thay đổi thì hãy mở file ClientMonitoring.dll.config và sửa trong thẻ appSettings, value của key ServerAddress.

## Hướng dẫn cách build và run app từ solution của Visual Studio

- Run file RoosterLottery.sln bằng Visual Studio, ở project Server, điền chuỗi connect đến SQL Server vào file appsettings.json ở thẻ DefaultConnection.
- Trước tiên là run project Server, sau đó lần lượt run các project Client và ClientMonitoring
* Lưu ý, project ClientMonitoring có dùng thư viện của DevExpress 23.1.6, nếu không view được giao diện design thì vui lòng cài đặt DevExpress trước.
