import VueRouter from 'vue-router'

//引入组件
import Index from '../pages'
import Home from '../pages/home/home'
import Login from '../pages/login/login'
import Register from '../pages/register/register'
import Center from '../pages/center/center'
import Storeup from '../pages/storeup/list'
import AddrList from '../pages/shop-address/list'
import AddrAdd from '../pages/shop-address/addOrUpdate'
import Order from '../pages/shop-order/list'
import OrderConfirm from '../pages/shop-order/confirm'
import Cart from '../pages/shop-cart/list'
import News from '../pages/news/news-list'
import NewsDetail from '../pages/news/news-detail'
import payList from '../pages/pay'

import yonghuList from '../pages/yonghu/list'
import yonghuDetail from '../pages/yonghu/detail'
import yonghuAdd from '../pages/yonghu/add'
import shangpinfenleiList from '../pages/shangpinfenlei/list'
import shangpinfenleiDetail from '../pages/shangpinfenlei/detail'
import shangpinfenleiAdd from '../pages/shangpinfenlei/add'
import gouwushangchengList from '../pages/gouwushangcheng/list'
import gouwushangchengDetail from '../pages/gouwushangcheng/detail'
import gouwushangchengAdd from '../pages/gouwushangcheng/add'
import cuxiaohuodongList from '../pages/cuxiaohuodong/list'
import cuxiaohuodongDetail from '../pages/cuxiaohuodong/detail'
import cuxiaohuodongAdd from '../pages/cuxiaohuodong/add'
import newstypeList from '../pages/newstype/list'
import newstypeDetail from '../pages/newstype/detail'
import newstypeAdd from '../pages/newstype/add'
import aboutusList from '../pages/aboutus/list'
import aboutusDetail from '../pages/aboutus/detail'
import aboutusAdd from '../pages/aboutus/add'
import systemintroList from '../pages/systemintro/list'
import systemintroDetail from '../pages/systemintro/detail'
import systemintroAdd from '../pages/systemintro/add'
import discussgouwushangchengList from '../pages/discussgouwushangcheng/list'
import discussgouwushangchengDetail from '../pages/discussgouwushangcheng/detail'
import discussgouwushangchengAdd from '../pages/discussgouwushangcheng/add'
import discusscuxiaohuodongList from '../pages/discusscuxiaohuodong/list'
import discusscuxiaohuodongDetail from '../pages/discusscuxiaohuodong/detail'
import discusscuxiaohuodongAdd from '../pages/discusscuxiaohuodong/add'

const originalPush = VueRouter.prototype.push
VueRouter.prototype.push = function push(location) {
	return originalPush.call(this, location).catch(err => err)
}

//配置路由
export default new VueRouter({
	routes:[
		{
      path: '/',
      redirect: '/index/home'
    },
		{
			path: '/index',
			component: Index,
			children:[
				{
					path: 'home',
					component: Home
				},
				{
					path: 'center',
					component: Center,
				},
				{
					path: 'pay',
					component: payList,
				},
				{
					path: 'storeup',
					component: Storeup
				},
                {
                    path: 'shop-address/list',
                    component: AddrList
                },
                {
                    path: 'shop-address/addOrUpdate',
                    component: AddrAdd
                },
				{
					path: 'shop-order/order',
					component: Order
				},
				{
					path: 'cart',
					component: Cart
				},
				{
					path: 'shop-order/orderConfirm',
					component: OrderConfirm
				},
				{
					path: 'news',
					component: News
				},
				{
					path: 'newsDetail',
					component: NewsDetail
				},
				{
					path: 'yonghu',
					component: yonghuList
				},
				{
					path: 'yonghuDetail',
					component: yonghuDetail
				},
				{
					path: 'yonghuAdd',
					component: yonghuAdd
				},
				{
					path: 'shangpinfenlei',
					component: shangpinfenleiList
				},
				{
					path: 'shangpinfenleiDetail',
					component: shangpinfenleiDetail
				},
				{
					path: 'shangpinfenleiAdd',
					component: shangpinfenleiAdd
				},
				{
					path: 'gouwushangcheng',
					component: gouwushangchengList
				},
				{
					path: 'gouwushangchengDetail',
					component: gouwushangchengDetail
				},
				{
					path: 'gouwushangchengAdd',
					component: gouwushangchengAdd
				},
				{
					path: 'cuxiaohuodong',
					component: cuxiaohuodongList
				},
				{
					path: 'cuxiaohuodongDetail',
					component: cuxiaohuodongDetail
				},
				{
					path: 'cuxiaohuodongAdd',
					component: cuxiaohuodongAdd
				},
				{
					path: 'newstype',
					component: newstypeList
				},
				{
					path: 'newstypeDetail',
					component: newstypeDetail
				},
				{
					path: 'newstypeAdd',
					component: newstypeAdd
				},
				{
					path: 'aboutus',
					component: aboutusList
				},
				{
					path: 'aboutusDetail',
					component: aboutusDetail
				},
				{
					path: 'aboutusAdd',
					component: aboutusAdd
				},
				{
					path: 'systemintro',
					component: systemintroList
				},
				{
					path: 'systemintroDetail',
					component: systemintroDetail
				},
				{
					path: 'systemintroAdd',
					component: systemintroAdd
				},
				{
					path: 'discussgouwushangcheng',
					component: discussgouwushangchengList
				},
				{
					path: 'discussgouwushangchengDetail',
					component: discussgouwushangchengDetail
				},
				{
					path: 'discussgouwushangchengAdd',
					component: discussgouwushangchengAdd
				},
				{
					path: 'discusscuxiaohuodong',
					component: discusscuxiaohuodongList
				},
				{
					path: 'discusscuxiaohuodongDetail',
					component: discusscuxiaohuodongDetail
				},
				{
					path: 'discusscuxiaohuodongAdd',
					component: discusscuxiaohuodongAdd
				},
			]
		},
		{
			path: '/login',
			component: Login
		},
		{
			path: '/register',
			component: Register
		},
	]
})
