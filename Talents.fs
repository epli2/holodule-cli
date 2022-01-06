module Talents

type Group =
    | Hololive
    | Gen0
    | Gen1
    | Gen2
    | Gamers
    | Gen3
    | Gen4
    | Gen5
    | HoloX
    | InnkMusic
    | English
    | Myth
    | ProjectHope
    | Council
    | Indonesia
    | Og
    | Holostars
    | HolostarsGen1
    | HolostarsGen2
    | HolostarsGen3
    | HolostarsOg

type TalentName = string

type Talent =
    { name: TalentName
      engName: string
      profileUrl: string
      icons: list<string>
      group: list<Group> }

let official =
    [ { name = "ホロライブ"
        engName = "Hololive"
        profileUrl = "https://hololive.hololivepro.com/"
        icons = [ "https://yt3.ggpht.com/a/AGF-l78roMKQjt4568VGVjmLkiOJ-25H9BxD_GH6QA=s88-c-k-c0xffffffff-no-rj-mo" ]
        group = [] }
      { name = "ホロスターズ"
        engName = "Holostars"
        profileUrl = "https://holostars.hololivepro.com/"
        icons = [ "https://yt3.ggpht.com/a/AGF-l78ocHbVqGFVON2-xicQ2EXPp_tX3vjPMDXY=s88-c-k-c0xffffffff-no-rj-mo" ]
        group = [] } ]

let dummyTalent =
    { name = "???"
      engName = "???"
      profileUrl = "https://www.hololive.tv/"
      icons = []
      group = [] }

let hololiveTalents =
    [ { name = "ときのそら"
        engName = "Tokino Sora"
        profileUrl = "https://hololive.hololivepro.com/talents/tokino-sora/"
        icons =
            [ "https://yt3.ggpht.com/ytc/AKedOLQO9Vyz7ysAwPSio5xvkw6n0xvlyDu7A9eawqIH3w=s176-c-k-c0x00ffffff-no-rj" ]
        group = [ Hololive; Gen0 ] }
      { name = "ロボ子さん"
        engName = "Robocosan"
        profileUrl = "https://hololive.hololivepro.com/talents/roboco-san/"
        icons = [ "https://yt3.ggpht.com/a/AGF-l79oElMmkIk3cuUa-CZY72QHuWT-P8ETYWvZLw=s88-c-k-c0xffffffff-no-rj-mo" ]
        group = [ Hololive; Gen0 ] }
      { name = "さくらみこ"
        engName = "Sakura Miko"
        profileUrl = "https://hololive.hololivepro.com/talents/sakuramiko/"
        icons =
            [ "https://yt3.ggpht.com/ytc/AKedOLQlZnbXr-RooUQezemDKu7alJrZcEMy8_5P07ILug=s176-c-k-c0x00ffffff-no-rj" ]
        group = [ Hololive; Gen0 ] }
      { name = "星街すいせい"
        engName = "Hoshimachi Suisei"
        profileUrl = "https://hololive.hololivepro.com/talents/hoshimachi-suisei/"
        icons = [ "https://yt3.ggpht.com/a/AGF-l797EAYufHUsLlwTxj7Vk_WIuQ0rBjEGEtgR6w=s88-c-k-c0xffffffff-no-rj-mo" ]
        group = [ Hololive; Gen0 ] }
      { name = "夜空メル"
        engName = "Yozora Mel"
        profileUrl = "https://hololive.hololivepro.com/talents/yozora-mel/"
        icons = [ "https://yt3.ggpht.com/a/AGF-l788-g4hDYP2xcs7CJzeEBfsZ48EMSjcJCZjBA=s88-c-k-c0xffffffff-no-rj-mo" ]
        group = [ Hololive; Gen1 ] }
      { name = "アキ・ローゼンタール"
        engName = "Aki Rosenthal"
        profileUrl = "https://hololive.hololivepro.com/talents/aki-rosenthal/"
        icons = [ "https://yt3.ggpht.com/a/AGF-l7-MKGs8oe830HpPIlyQ3pNAVqUgqiMdSg8TwQ=s88-c-k-c0xffffffff-no-rj-mo" ]
        group = [ Hololive; Gen1 ] }
      { name = "赤井はあと"
        engName = "Akai Haato"
        profileUrl = "https://hololive.hololivepro.com/talents/akai-haato/"
        icons = [ "https://yt3.ggpht.com/a/AGF-l7-ULNK73gTCGtPrM6elTCL-ValOSptM0YTXkQ=s88-c-k-c0xffffffff-no-rj-mo" ]
        group = [ Hololive; Gen1; Gamers ] }
      { name = "白上フブキ"
        engName = "Shirakami Fubuki"
        profileUrl = "https://hololive.hololivepro.com/talents/shirakami-fubuki/"
        icons = [ "https://yt3.ggpht.com/a/AGF-l7-oeSvjxgdwMoDyT1LMH8nyqkWJCZH8MAOjzg=s88-c-k-c0xffffffff-no-rj-mo" ]
        group = [ Hololive; Gen1 ] }
      { name = "夏色まつり"
        engName = "Natsuiro Matsuri"
        profileUrl = "https://hololive.hololivepro.com/talents/natsuiro-matsuri/"
        icons = [ "https://yt3.ggpht.com/a/AGF-l7_MTJEH9Kn-cVznPJPBt4v0BOkmd5btoSdz6Q=s88-c-k-c0xffffffff-no-rj-mo" ]
        group = [ Hololive; Gen1 ] }
      { name = "湊あくあ"
        engName = "Minato Aqua"
        profileUrl = "https://hololive.hololivepro.com/talents/minato-aqua/"
        icons = [ "https://yt3.ggpht.com/a/AGF-l79lFypl4LxY5kf60UpCL6gakgSGHtN-t8hq1g=s88-c-k-c0xffffffff-no-rj-mo" ]
        group = [ Hololive; Gen2 ] }
      { name = "紫咲シオン"
        engName = "Murasaki Shion"
        profileUrl = "https://hololive.hololivepro.com/talents/murasaki-shion/"
        icons =
            [ "https://yt3.ggpht.com/AyUL9W0ltc_aJr_MysuZBx8hRfb1SIVNREgU9kiOO-lqmdhYkEsllmhagertVIwHwa3UAAKy=s176-c-k-c0x00ffffff-no-rj" ]
        group = [ Hololive; Gen2 ] }
      { name = "百鬼あやめ"
        engName = "Nakiri Ayame"
        profileUrl = "https://hololive.hololivepro.com/talents/nakiri-ayame/"
        icons =
            [ "https://yt3.ggpht.com/XDGhKwPZcT16Ppg2gQmLHEIYRhw9sY4rqG0HWbeCH68LHkhlVQrrFgxd5hWUuMb2nLfDOhu6=s176-c-k-c0x00ffffff-no-rj" ]
        group = [ Hololive; Gen2 ] }
      { name = "癒月ちょこ"
        engName = "Yuzuki Choco"
        profileUrl = "https://hololive.hololivepro.com/talents/yuzuki-choco/"
        icons =
            [ "https://yt3.ggpht.com/a/AGF-l79rj4svlTtPimVkcxdUJS8VGt01u_mqZWZIbA=s88-c-k-c0xffffffff-no-rj-mo"
              "https://yt3.ggpht.com/a/AGF-l79qZWKzqRbNcbmfTY-kzLAcHtjui-IvB2ktDw=s48-c-k-c0xffffffff-no-rj-mo" ]
        group = [ Hololive; Gen2 ] }
      { name = "大空スバル"
        engName = "Oozora Subaru"
        profileUrl = "https://hololive.hololivepro.com/talents/oozora-subaru/"
        icons = [ "https://yt3.ggpht.com/a/AGF-l79ydxWz0XWeOkKy59UT9X_pPEMBzIO2-W0GTg=s88-c-k-c0xffffffff-no-rj-mo" ]
        group = [ Hololive; Gen2 ] }
      { name = "大神ミオ"
        engName = "Ookami Mio"
        profileUrl = "https://hololive.hololivepro.com/talents/ookami-mio/"
        icons = [ "https://yt3.ggpht.com/a/AGF-l78s_0WRnL7hthbRZPmmLSKSCKsxM2DI9FXyAQ=s88-c-k-c0xffffffff-no-rj-mo" ]
        group = [ Hololive; Gamers ] }
      { name = "猫又おかゆ"
        engName = "Nekomata Okayu"
        profileUrl = "https://hololive.hololivepro.com/talents/nekomata-okayu/"
        icons = [ "https://yt3.ggpht.com/a/AGF-l79MqKq01ItJYUYJ1i5lp0AL0AEnnTTNh62aug=s88-c-k-c0xffffffff-no-rj-mo" ]
        group = [ Hololive; Gamers ] }
      { name = "戌神ころね"
        engName = "Inugami Korone"
        profileUrl = "https://hololive.hololivepro.com/talents/inugami-korone/"
        icons =
            [ "https://yt3.ggpht.com/ytc/AKedOLSegxVNNn4QGDwO-jO89ZDcYLSyPUQS3a4KU6QPCw=s176-c-k-c0x00ffffff-no-rj" ]
        group = [ Hololive; Gamers ] }
      { name = "兎田ぺこら"
        engName = "Usada Pekora"
        profileUrl = "https://hololive.hololivepro.com/talents/usada-pekora/"
        icons = [ "https://yt3.ggpht.com/a/AGF-l783JgU1dmBOzvsmUfnbMLLOD1c0Gvuo7TKiVw=s88-c-k-c0xffffffff-no-rj-mo" ]
        group = [ Hololive; Gen3 ] }
      { name = "潤羽るしあ"
        engName = "Uruha Rushia"
        profileUrl = "https://hololive.hololivepro.com/talents/uruha-rushia/"
        icons = [ "https://yt3.ggpht.com/a/AGF-l7-Qgi-J6qJG7c79iMtEveIZIgZVCyltxCh1jA=s88-c-k-c0xffffffff-no-rj-mo" ]
        group = [ Hololive; Gen3 ] }
      { name = "不知火フレア"
        engName = "Shiranui Flare"
        profileUrl = "https://hololive.hololivepro.com/talents/shiranui-flare/"
        icons =
            [ "https://yt3.ggpht.com/d9aIrGtZR0eI4k1Wnev5f_R4llIBsWnQOjkdsqkMycoAxA3g_zz-jyeBl8tEHfbm1iTg0SJj=s176-c-k-c0x00ffffff-no-rj" ]
        group = [ Hololive; Gen3 ] }
      { name = "白銀ノエル"
        engName = "Shirogane Noel"
        profileUrl = "https://hololive.hololivepro.com/talents/shirogane-noel/"
        icons = [ "https://yt3.ggpht.com/a/AGF-l7_JlV2irL6SKbyQWEuyWXU0UnMQqFP87bxzTg=s88-c-k-c0xffffffff-no-rj-mo" ]
        group = [ Hololive; Gen3 ] }
      { name = "宝鐘マリン"
        engName = "Houshou Marine"
        profileUrl = "https://hololive.hololivepro.com/talents/houshou-marine/"
        icons = [ "https://yt3.ggpht.com/a/AGF-l7_dX9d8sMDya_L_ApF7pxUSiwtSOId7Bufd-g=s88-c-k-c0xffffffff-no-rj-mo" ]
        group = [ Hololive; Gen3 ] }
      { name = "天音かなた"
        engName = "Amane Kanata"
        profileUrl = "https://hololive.hololivepro.com/talents/amane-kanata/"
        icons =
            [ "https://yt3.ggpht.com/TlH8nz5O9UYo5JZ_5fo4JfXdT18N0Ck27wWrulni-c1g5bwes0tVmFiSKICzI1SW7itaTkk9GA=s176-c-k-c0x00ffffff-no-rj" ]
        group = [ Hololive; Gen4 ] }
      { name = "角巻わため"
        engName = "Tsunomaki Watame"
        profileUrl = "https://hololive.hololivepro.com/talents/tsunomaki-watame/"
        icons = [ "https://yt3.ggpht.com/a/AGF-l78pYNGWXckjVjmMsSz4iPeCzmWB2DHFW3lLdQ=s88-c-k-c0xffffffff-no-rj-mo" ]
        group = [ Hololive; Gen4 ] }
      { name = "常闇トワ"
        engName = "Tokoyami Towa"
        profileUrl = "https://hololive.hololivepro.com/talents/tokoyami-towa/"
        icons =
            [ "https://yt3.ggpht.com/meRnxbRUm5yPSwq8Q5QpI5maFApm5QTGQV_LGblQFsoO0yAV4LI-nSZ70GYwMZ_tbfSa_O8MTCU=s176-c-k-c0x00ffffff-no-rj" ]
        group = [ Hololive; Gen4 ] }
      { name = "姫森ルーナ"
        engName = "Himemori Luna"
        profileUrl = "https://hololive.hololivepro.com/talents/himemori-luna/"
        icons =
            [ "https://yt3.ggpht.com/yVg0ujw11JN5YSykr-63ivgudlC5PE5Kzn3Cpm7eFWVB7fxtcJvTXcG1M_9tFHETJ7144NO6=s176-c-k-c0x00ffffff-no-rj" ]
        group = [ Hololive; Gen4 ] }
      { name = "桐生ココ"
        engName = "Kiryu Coco"
        profileUrl = "https://hololive.hololivepro.com/talents/kiryu-coco/"
        icons =
            [ "https://yt3.ggpht.com/ytc/AKedOLQUA2htopp_nUXZScvJvh17wlOhSvcjAc-L75meCg=s176-c-k-c0x00ffffff-no-rj" ]
        group = [ Hololive; Gen4; Og ] }
      { name = "雪花ラミィ"
        engName = "Yukihana Lamy"
        profileUrl = "https://hololive.hololivepro.com/talents/yukihana-lamy/"
        icons = [ "https://yt3.ggpht.com/a/AATXAJzN5Oo_0gI5qPUclliWy8EzU9x5z4oIYliAB3bf=s100-c-k-c0xffffffff-no-rj-mo" ]
        group = [ Hololive; Gen5 ] }
      { name = "桃鈴ねね"
        engName = "Momosuzu Nene"
        profileUrl = "https://hololive.hololivepro.com/talents/momosuzu-nene/"
        icons =
            [ "https://yt3.ggpht.com/bMBMxmB1YVDVazU-8KbB6JZqUHn4YzmFiQRWwEUHCeqm5REPW7HHQChC5xE6e36aqqnXgK4a=s176-c-k-c0x00ffffff-no-rj" ]
        group = [ Hololive; Gen5 ] }
      { name = "獅白ぼたん"
        engName = "Shishiro Botan"
        profileUrl = "https://hololive.hololivepro.com/talents/shishiro-botan/"
        icons = [ "https://yt3.ggpht.com/a/AATXAJzO_bOBHuKPycvddNd88hozl2OjaNC-uR7lOAXa=s100-c-k-c0xffffffff-no-rj-mo" ]
        group = [ Hololive; Gen5 ] }
      { name = "尾丸ポルカ"
        engName = "Omaru Polka"
        profileUrl = "https://hololive.hololivepro.com/talents/omaru-polka/"
        icons = [ "https://yt3.ggpht.com/a/AATXAJzMPMCRzpyIsPyp8cOdA2FUwkBotqe6Dh0CmKgA=s100-c-k-c0xffffffff-no-rj-mo" ]
        group = [ Hololive; Gen5 ] }
      { name = "ラプラス・ダークネス"
        engName = "La+ Darknesss"
        profileUrl = "https://hololive.hololivepro.com/talents/la-darknesss/"
        icons =
            [ "https://yt3.ggpht.com/roGS60A8a_lDbVakIg1JU3u3hbtjHSTilMGHMizuPKh7tuoY2nl46raxuW2f_83IKFGMjL6Z=s176-c-k-c0x00ffffff-no-rj" ]
        group = [ Hololive; HoloX ] }
      { name = "鷹嶺ルイ"
        engName = "Takane Lui"
        profileUrl = "https://hololive.hololivepro.com/talents/takane-lui/"
        icons =
            [ "https://yt3.ggpht.com/KO_kRAeAQ4C4M5xJDFOFHZ79ycCRfMxttefXIDFurZE2fsVPnmlHkMdM5zjEsUTH1i97xnxKNw=s176-c-k-c0x00ffffff-no-rj" ]
        group = [ Hololive; HoloX ] }
      { name = "博衣こより"
        engName = "Hakui Koyori"
        profileUrl = "https://hololive.hololivepro.com/talents/hakui-koyori/"
        icons =
            [ "https://yt3.ggpht.com/DNC5rGjlwA4Ae7rhpPmkv_QdjJPl8AfpQT9NcXTLvPbbriL-Y0Ni-gYfFH8uoiF6Ay1EP9VnZAk=s176-c-k-c0x00ffffff-no-rj" ]
        group = [ Hololive; HoloX ] }
      { name = "沙花叉クロヱ"
        engName = "https://hololive.hololivepro.com/talents/sakamata-chloe/"
        profileUrl = "Sakamata Chloe"
        icons =
            [ "https://yt3.ggpht.com/_xNtPLKQcQxMTnOr4tAcGz0GEeESsi0bQX9mJEP3fx_50a8GUfUyOG1eyLIld2cCz6GvKABwpQ=s176-c-k-c0x00ffffff-no-rj" ]
        group = [ Hololive; HoloX ] }
      { name = "風真いろは"
        engName = "Kazama Iroha"
        profileUrl = "https://hololive.hololivepro.com/talents/kazama-iroha/"
        icons = [ "https://schedule-static.hololive.tv/image/38680fcce2ca.jpg" ]
        group = [ Hololive; HoloX ] }
      { name = "AZKi"
        engName = "AZKi"
        profileUrl = "https://hololive.hololivepro.com/talents/azki/"
        icons = [ "https://yt3.ggpht.com/a/AGF-l78sBjQprltHOV3ptIVwxDTpYTpXk-_ad2huMQ=s88-c-k-c0xffffffff-no-rj-mo" ]
        group = [ InnkMusic ] }
      { name = "森カリオペ"
        engName = "Mori Calliope"
        profileUrl = "https://hololive.hololivepro.com/talents/mori-calliope/"
        icons = [ "https://yt3.ggpht.com/a/AATXAJyQbZx8HMH0-qpLVU-GP21qqkIQ2Lc_InI1nw=s100-c-k-c0xffffffff-no-rj-mo" ]
        group = [ English; Myth ] }
      { name = "小鳥遊キアラ"
        engName = "Takanashi Kiara"
        profileUrl = "https://hololive.hololivepro.com/talents/takanashi-kiara/"
        icons =
            [ "https://yt3.ggpht.com/w7TKJYU7zmamFmf-WxfahCo_K7Bg2__Pk-CCBNnbewMG-77OZLqJO9MLvDAmH9nEkZH8OkWgSQ=s176-c-k-c0x00ffffff-no-rj" ]
        group = [ English; Myth ] }
      { name = "一伊那尓栖"
        engName = "Ninomae Ina'nis"
        profileUrl = "https://hololive.hololivepro.com/talents/ninomae-inanis/"
        icons = [ "https://yt3.ggpht.com/a/AATXAJzxDWqRp17fR1oUJtIKD3o-hRjs0HE-4GQmtQ=s100-c-k-c0xffffffff-no-rj-mo" ]
        group = [ English; Myth ] }
      { name = "がうる・ぐら"
        engName = "Gawr Gura"
        profileUrl = "https://hololive.hololivepro.com/talents/gawr-gura/"
        icons = [ "https://yt3.ggpht.com/a/AATXAJzvdjbcKIP9RDDQJjcBh8t6AK-pQSV_zQqFtA=s100-c-k-c0xffffffff-no-rj-mo" ]
        group = [ English; Myth ] }
      { name = "ワトソン・アメリア"
        engName = "Watson Amelia"
        profileUrl = "https://hololive.hololivepro.com/talents/watson-amelia/"
        icons = [ "https://yt3.ggpht.com/a/AATXAJy4N7OLrI5euxdzCX_OiS6hDbHUSqqIJoWK_170=s100-c-k-c0xffffffff-no-rj-mo" ]
        group = [ English; Myth ] }
      { name = "アイリス"
        engName = "IRyS"
        profileUrl = "https://hololive.hololivepro.com/talents/irys/"
        icons =
            [ "https://yt3.ggpht.com/UwxlX1PuB_RwJyEUW_ofbBR6saY8n5_p8A9_1bY65zygFrfqIb1GM8dIK33EJboDDnRVyw=s176-c-k-c0x00ffffff-no-rj" ]
        group = [ English; ProjectHope ] }
      { name = "九十九佐命"
        engName = "Tsukumo Sana"
        profileUrl = ""
        icons =
            [ "https://yt3.ggpht.com/t1XymJVoo8trXNJ1PeHTzaROF5wqlBYigFoYzw0HEthLahxAXjpqBi6c5ttOp9kWkYCkspivEg=s176-c-k-c0x00ffffff-no-rj" ]
        group = [ English; Council ] }
      { name = "セレス・ファウナ"
        engName = "Ceres Fauna"
        profileUrl = "https://hololive.hololivepro.com/talents/ceres-fauna/"
        icons =
            [ "https://yt3.ggpht.com/1rUoSkwh5LJbR8ez3-l02cdoOIKt9IlhKJxkBTqoff2qZb-VV3wUTFpkE2cNDQnOjk8wR-TW=s176-c-k-c0x00ffffff-no-rj" ]
        group = [ English; Council ] }
      { name = "オーロ・クロニー"
        engName = "Ouro Kronii"
        profileUrl = "https://hololive.hololivepro.com/talents/ouro-kronii/"
        icons =
            [ "https://yt3.ggpht.com/6670YE31bbAtAi7m_UL-KWZBdL5wvmfHlLtcS4HxsBZBQNqmAk7Y-iiIOjawO_0HYXpS4HfC=s176-c-k-c0x00ffffff-no-rj" ]
        group = [ English; Council ] }
      { name = "七詩ムメイ"
        engName = "Nanashi Mumei"
        profileUrl = "https://hololive.hololivepro.com/talents/nanashi-mumei/"
        icons =
            [ "https://yt3.ggpht.com/owZmjfnG_SGVmfkl3eS7Lv47pGvIr2SrS36imh6O8i0H3Wy41fYKD26U7wnyRB627fXoq0aQ0Q=s176-c-k-c0x00ffffff-no-rj" ]
        group = [ English; Council ] }
      { name = "ハコス・ベールズ"
        engName = "Hakos Baelz"
        profileUrl = "https://hololive.hololivepro.com/talents/hakos-baelz/"
        icons =
            [ "https://yt3.ggpht.com/GWIwRbtVQ2TAlvH8Mf37FMpemTrwmUSbTSazp9Aul6KwdKQmvx7IbLZepDk0sp8ReW3qBhsU=s176-c-k-c0x00ffffff-no-rj" ]
        group = [ English; Council ] }
      { name = "アユンダ・リス"
        engName = "Ayunda Risu"
        profileUrl = "https://hololive.hololivepro.com/talents/ayunda-risu/"
        icons =
            [ "https://yt3.ggpht.com/ytc/AKedOLTjqfaFS9JlspGjiIah2kkxOtl4vRrxBCYKMEY5Kw=s176-c-k-c0x00ffffff-no-rj" ]
        group = [ Indonesia ] }
      { name = "ムーナ・ホシノヴァ"
        engName = "Moona Hoshinova"
        profileUrl = "https://hololive.hololivepro.com/talents/moona-hoshinova/"
        icons =
            [ "https://yt3.ggpht.com/ytc/AKedOLRaHP1Qoi3zFxbQYdbX4MNnV18TrqjFBwDxgTlNqg=s176-c-k-c0x00ffffff-no-rj" ]
        group = [ Indonesia ] }
      { name = "アイラニ・イオフィフティーン"
        engName = "Airani Iofifteen"
        profileUrl = "https://hololive.hololivepro.com/talents/airani-iofifteen/"
        icons = [ "https://yt3.ggpht.com/a/AATXAJySvEN5jcGQcayvU54AjxPhIUKAvz7PmXLfqQ=s288-c-k-c0xffffffff-no-rj-mo" ]
        group = [ Indonesia ] }
      { name = "クレイジー・オリー"
        engName = "Kureiji Ollie"
        profileUrl = "https://hololive.hololivepro.com/talents/kureiji-ollie/"
        icons =
            [ "https://yt3.ggpht.com/jWxru6sHDDSuKF-gztFg_WSoMp2da_d019iH0xz0MDWc7TIhetK8id_mVKV0PxWKp-QS23AzfQ=s176-c-k-c0x00ffffff-no-rj" ]
        group = [ Indonesia ] }
      { name = "アーニャ・メルフィッサ"
        engName = "Anya Melfissa"
        profileUrl = "https://hololive.hololivepro.com/talents/anya-melfissa/"
        icons = [ "https://yt3.ggpht.com/ytc/AAUvwnjtG59rMdKU3b_wYRIX_EnfAUKVuAM5s-ePaw=s176-c-k-c0x00ffffff-no-rj" ]
        group = [ Indonesia ] }
      { name = "パヴォリア・レイネ"
        engName = "Pavolia Reine"
        profileUrl = "https://hololive.hololivepro.com/talents/pavolia-reine/"
        icons = [ "https://yt3.ggpht.com/ytc/AAUvwngRWmguZ0ERjbs2KgMeZoj9kSWVGVXmwZb-CA=s176-c-k-c0x00ffffff-no-rj" ]
        group = [ Indonesia ] } ]

let holostarsTalents =
    [ { name = "花咲みやび"
        engName = "Hanasaki Miyabi"
        profileUrl = "https://holostars.hololivepro.com/talent/hanasaki-miyabi/"
        icons =
            [ "https://yt3.ggpht.com/zxQf8fShPDdHyNGTIGdP1sZ2w-wFTw9BYWupkB9mL1fr3dHEbd5-vhVJ6iA7RdNP8ixpbfOR_g=s176-c-k-c0x00ffffff-no-rj" ]
        group = [ Holostars; HolostarsGen1 ] }
      { name = "奏手イヅル"
        engName = "Kanade Izuru"
        profileUrl = "https://holostars.hololivepro.com/talent/kanade-izuru/"
        icons = []
        group = [ Holostars; HolostarsGen1 ] }
      { name = "アルランディス"
        engName = "Arurandeisu"
        profileUrl = "https://holostars.hololivepro.com/talent/arurandeisu/"
        icons = [ "https://yt3.ggpht.com/a/AGF-l79f3jWQcTlix8TIcliA8M07gXg0OpsJ-aD4fQ=s88-c-k-c0xffffffff-no-rj-mo" ]
        group = [ Holostars; HolostarsGen1 ] }
      { name = "律可"
        engName = "Rikka"
        profileUrl = "https://holostars.hololivepro.com/talent/rikka/"
        icons =
            [ "https://yt3.ggpht.com/0MLL-S2KKu4PlhedunMhvg4VPJGm6Fpx2C4QV2PWJvkcG1eA6XqUYULUZGqBF2M4iNY7FxBt=s176-c-k-c0x00ffffff-no-rj" ]
        group = [ Holostars; HolostarsGen1 ] }
      { name = "アステル・レダ"
        engName = "Astel Leda"
        profileUrl = "https://holostars.hololivepro.com/talent/astel-leda/"
        icons =
            [ "https://yt3.ggpht.com/sr2RTZaWAFF20tSTiXUXp-BYRqWz4dZhFKbCzFS2dneTN5uSE53sSDjePN5dIM_sEz2U9-2qtRs=s176-c-k-c0x00ffffff-no-rj" ]
        group = [ Holostars; HolostarsGen2 ] }
      { name = "岸堂天真"
        engName = "Kishido Temma"
        profileUrl = "https://holostars.hololivepro.com/talent/kishido-temma/"
        icons = [ "https://yt3.ggpht.com/a/AGF-l78r-BLKS2x8csXx1EjyYIKVNB1XinLx-ngefQ=s88-c-k-c0xffffffff-no-rj-mo" ]
        group = [ Holostars; HolostarsGen2 ] }
      { name = "夕刻ロベル"
        engName = "Yukoku Roberu"
        profileUrl = "https://holostars.hololivepro.com/talent/yukoku-roberu/"
        icons =
            [ "https://yt3.ggpht.com/yVTO0I6VAXBjBLBPvgLGlBlp1hganldhl6AY3PW_ZWOJ0sYwfLo1yc2Sqr5SMjXQf7Dm4U-2=s176-c-k-c0x00ffffff-no-rj" ]
        group = [ Holostars; HolostarsGen2 ] }
      { name = "影山シエン"
        engName = "Kageyama Shien"
        profileUrl = "https://holostars.hololivepro.com/talent/kageyama-shien/"
        icons =
            [ "https://yt3.ggpht.com/N20GfJbuG8BBl9CexUek023y2DXQAYqgYoRRqsVGAYoS-gZsGuH7W1Il0y-8TnIul19rBPG78Jo=s176-c-k-c0x00ffffff-no-rj" ]
        group = [ Holostars; HolostarsGen3 ] }
      { name = "荒咬オウガ"
        engName = "Aragami Oga"
        profileUrl = "https://holostars.hololivepro.com/talent/aragami-oga/"
        icons = [ "https://yt3.ggpht.com/a/AATXAJw1uO0nfGubUVQ_ubZbdwO4ELqkyAJde43HfA=s100-c-k-c0xffffffff-no-rj-mo" ]
        group = [ Holostars; HolostarsGen3 ] }
      { name = "鏡見キラ"
        engName = "Kagami Kira"
        profileUrl = "https://holostars.hololivepro.com/talent/kagami-kira/"
        icons = [ "https://yt3.ggpht.com/ytc/AKedOLSlv5sku0umxqGTUZnfX4c89WKyIQmlsjNqI4Yd=s176-c-k-c0x00ffffff-no-rj" ]
        group = [ Holostars; HolostarsOg ] } ]

let talents =
    List.append hololiveTalents holostarsTalents
