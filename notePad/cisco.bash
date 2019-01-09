配置vlan（接口物理隔离）
Switch#configure terminal
Switch(config)#interface fastEthernet 0/1
Switch(config-if)#switchport access vlan 2

配置静态路由表（遇到对应ip直接转发到接口）
Router(config)#ip route 192.168.3.0 255.255.255.0 fastEthernet 0/1

配置动态路由（填入已知ip段并自动学习转发）
Router(config)#router rip
Router(config-router)#network 192.168.1.0
Router(config-router)#network 192.168.2.0

