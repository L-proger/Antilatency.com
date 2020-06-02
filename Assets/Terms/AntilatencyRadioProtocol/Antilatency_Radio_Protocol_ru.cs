using Csml;
partial class Terms {
    public static Material Antilatency_Radio_Protocol_ru => new Material(null,  null,
    $"Для передачи данных по радиоканалу в устройствах Antilatency используется проприетарный радиопротокол, работающий на частоте 2.4ГГц. Радиопротокол оптимизирован для работы в режиме реального и обладает низкой задержкой при передаче данных (low latency).")
        [new Section("Устройства с поддержкой Antilatency Radio Protocol")
            [$"Список приемников"]
            [new UnorderedList()
                [$"{Hardware.SocketUsbRadio}"]
            ]

            [$"Список передатчиков"]
            [new UnorderedList()
                [$"{Hardware.Tag}"]
                [$"{Hardware.Bracer}"]
            ]
        ]
        [new Section("Топология подключения устройств по радиопротоколу")
            [$"В {Terms.Antilatency_Radio_Protocol} можно выделить два типа устройств: "]
            [new OrderedList()
                [$"Приёмник (Master)"]
                [$"Передатчик (Slave)"]
            ]
            [@$"Передатчики подключаются к приемнику и передают ему свои данные. 
                Задача приёмника - собрать данные со всех передатчиков, добавить собственные данные и отправить на {Terms.Host} по другому интерфейсу (например, по USB).
                В качестве приемника могут выступать, например, {Hardware.SocketUsbRadio} или {Hardware.PicoG2Socket}. 
                В качестве передатчиков могут выступать например, {Hardware.Tag} или {Hardware.Bracer}.
            "]
            [new Info()
                [$"{Hardware.SocketUsbRadio} может выступать как в роли приемника, так и в роли передатчика, в зависимости от конфигурации. "]
            ]
            [$"Таким образом, стандартная схема подключения устройств по радиопротоколу к {Terms.Host} выглядит следующим образом:"]
            [new OrderedList()
                [$"Подключение приемника к {Terms.Host} по USB."]
                [$"Подключение передатчиков к приемнику по радиопротколу"]
            ]
            [AntilatencyRadioProtocolTopology]
            [$"Для конфигурации устройств с поддержкой {Terms.Antilatency_Radio_Protocol} см. раздел {Tutorials.ConfiguringRadioDevices}"]
        ]

        [new Section("Подключение нескольких устройств к одному приемнику")
            [@$"К одному приемнику может быть подключено несколько передатчиков. Приемник по очереди опрашивает подключенные к нему передатчики для получения данных.
                Пропускная способность радиоканала приемника делится между всеми подключенными к нему передатчиками. 
                Общая пропускная способность радиоканала приемника составляет 1.6Mbit/s. 
                Таким образом, пропускная способность канала между приемником и передатчиком составляет, в частности:
            "]
            [new UnorderedList()
                [$"1 приемник - 1 передатчик = 1.6 Mbit/s"]
                [$"1 приемник - 2 передатчика по 0.8 Mbit/s"]
                [$"1 приемник - 3 передачтика по 0.53 Mbit/s"]
            ]
            [new Warning()
                [$"Рекомендуется к одному приемнику не подключать более 4 передатчиков с трекерами"]
            ]
            [new Error()
                [$"TODO:Перевод In case of an unstable radio connection caused by the distance between the USB socket and the wireless socket, some obstacles between these sockets, or additional radio noise on this channel from other emitters. In this case, some packets from the wireless socket may be lost which will lead to tracking task being restarted on the Alt tracker that connected to the wireless socket."] 
            ]           
        ]

        [new Section("Доступные каналы","channels")
            [$"Для передачи данных по радиопротоколу приемнику может быть установлен любой из 141 радиоканалов из диапазона 2360-2500 MHz."]
            [new Warning()
                [$"В некоторых странах использование части каналов из указанного диапазона требует серификации (например, 2360-2400 MHz, 2488-2500 MHz). Перед использованием уточните возможность использования канала из этого диапазона для вашей страны."]
            ]
            [@$"Выбор радиоканала в программном обеспечении производится по принципу: индекс 0 = 2360 MHz, индекс 140 = 2500 MHz.
                Если у приемника не был выставлен конкретный радиоканал, приемник выберет первый свободный радиоканал из списка каналов:
            "]
            [new UnorderedList()
                [$"42 = 2402 MHz"]
                [$"66 = 2426 MHz"]
                [$"92 = 2452 MHz"]
                [$"114 = 2474 MHz"]
                [$"120 = 2480 MHz"]
            ]
            [$"Данный список каналов приведен на схеме ниже."]
            [RadioChannelsImage]
            [new Info()
                [$"При выборе приемником одного из каналов, отображенных на схеме, светодиод приемника загорится соответствующим цветом канала, указанным на схеме."]
            ]            
        ]

        [new Section("Работа нескольких приемников в одном помещении") 
            [$"В одном помещении могут работать несколько приемников и даже к одному хосту может быть подключено несколько приемников. При этом у приемников, работающих в одном помещении должны быть установлены разные каналы."]
            [MultipleChannelsImage]
            [$"На качество работы нескольких приемников в одном помещении влияют следующие факторы:"]
            [new UnorderedList()
                [@$"внешние факторы, такие как общий радиофон в помещении.
                    Наличие и конфигурация WiFi сетей в помещении может влиять на качество работы радиоустройств. Antilatency Radio Protocol работает на частоте 2.4 ГГц. 
                    Перед выбором радиоканалов рекомендуется просканировать диапазон 2.4ГГц в помещении.
                "]
            ]
            [new Info()
                [$"Если есть возможность конфигурации WiFi сетей в помещении, строго рекомендуется сконфигурировать WiFi устройства на частоте 5 ГГц. "]
            ]
            [new UnorderedList()
                [@$"расстояние между каналами, установленными для приемников.
                    Чем ближе каналы друг к другу, тем сильнее устройства на соседних каналах  мешают друг другу. В зависимости от предполагаемого условия использования необходимо выбрать минимальную дистанцию между каналами. 
                    Дистанция в 6 каналов обеспечивает почти полное отсутствие влияния на расстоянии пол метра между приемниками. 
                    Дистанция менее 6 каналов может оказывать влияние на стабильность работы большого количества передатчиков, подключенных к 1 приемнику. Стоит уменьшить количество передатчиков, подключенных к 1 приемнику, чтобы улучшить стабильность и отзывчивость сети.
                "]
            ]
            [new Warning()
                [$"Во избежании нестабильной работы сети из-за взаимных помех строго не рекомендуется использовать дистанцию менее 4 каналов. "]
            ]
            [new UnorderedList()
                [@$"физическое расстояние между приемниками.
                    Приемники даже с разными каналами не должны располагаться близко друг к другу. Чем физически приемники ближе друг к другу - тем сильнее взаимное влияние. 
                "]
            ]
            [new Warning()
                [$"Во избежании помех рекомендуется располагать приемники на расстоянии не ближе 0.5 метра друг от друга."]
            ]

        ]
    ;
    


}