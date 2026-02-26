using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Shop;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x020000A9 RID: 169
	[Token(Token = "0x20000A9")]
	public class ShopService : AbstractService
	{
		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x000030C0 File Offset: 0x000012C0
		[Token(Token = "0x170000AC")]
		public override short ServiceId
		{
			[Token(Token = "0x600065B")]
			[Address(RVA = "0x5A5C", Offset = "0x5A5C", VA = "0x5A5C", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x140000A0 RID: 160
		// (add) Token: 0x0600065C RID: 1628 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600065D RID: 1629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000A0")]
		public event Action<ProtoArtifactBuyedEvt> ArtifactBuyedEvent
		{
			[Token(Token = "0x600065C")]
			[Address(RVA = "0x5A5D", Offset = "0x5A5D", VA = "0x5A5D")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600065D")]
			[Address(RVA = "0x5A5E", Offset = "0x5A5E", VA = "0x5A5E")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000A1 RID: 161
		// (add) Token: 0x0600065E RID: 1630 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600065F RID: 1631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000A1")]
		public event Action<ProtoArtifactMovedEvt> ArtifactMovedEvent
		{
			[Token(Token = "0x600065E")]
			[Address(RVA = "0x5A5F", Offset = "0x5A5F", VA = "0x5A5F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600065F")]
			[Address(RVA = "0x5A60", Offset = "0x5A60", VA = "0x5A60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000A2 RID: 162
		// (add) Token: 0x06000660 RID: 1632 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000661 RID: 1633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000A2")]
		public event Action<ProtoMarketArtifactsAddedEvt> MarketArtifactsAddedEvent
		{
			[Token(Token = "0x6000660")]
			[Address(RVA = "0x5A61", Offset = "0x5A61", VA = "0x5A61")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000661")]
			[Address(RVA = "0x5A62", Offset = "0x5A62", VA = "0x5A62")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000A3 RID: 163
		// (add) Token: 0x06000662 RID: 1634 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000663 RID: 1635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000A3")]
		public event Action<ProtoMarketArtifactsRemovedEvt> MarketArtifactsRemovedEvent
		{
			[Token(Token = "0x6000662")]
			[Address(RVA = "0x5A63", Offset = "0x5A63", VA = "0x5A63")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000663")]
			[Address(RVA = "0x5A64", Offset = "0x5A64", VA = "0x5A64")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000A4 RID: 164
		// (add) Token: 0x06000664 RID: 1636 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000665 RID: 1637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000A4")]
		public event Action<ProtoMarketOptionsDisabledEvt> MarketOptionsDisabledEvent
		{
			[Token(Token = "0x6000664")]
			[Address(RVA = "0x5A65", Offset = "0x5A65", VA = "0x5A65")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000665")]
			[Address(RVA = "0x5A66", Offset = "0x5A66", VA = "0x5A66")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000666")]
		[Address(RVA = "0x5A67", Offset = "0x5A67", VA = "0x5A67", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		/* --- GHIDRA: ServerEventHandler ---
		undefined4
		ServicesNamespace_ShopService__ServerEventHandler
		          (undefined4 param1,undefined8 param2,undefined4 param3)
		
		{
		  int param3_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a55a6c == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Shop_ProtoGetShopItemsInfoCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_ServicesNamespace_ShopService_Request_ProtoGetShopItemsInfoAns__ProtoGetShopItemsInfoCmd___
		              );
		    DAT_ram_00a55a6c = '\x01';
		  }
		  param3_00 = unnamed_function_1417(Protocol_Shop_ProtoGetShopItemsInfoCmd_TypeInfo);
		  *(undefined8 *)(param3_00 + 0x10) = param2;
		  uVar1 = ServicesNamespace_ShopService__Request___Il2CppFullySharedGenericType_
		                    (param1,1,param3_00,
		                     Method_ServicesNamespace_ShopService_Request_ProtoGetShopItemsInfoAns__ProtoGetShopItemsInfoCmd___
		                    );
		  return uVar1;
		}
		*/

		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000667")]
		[Address(RVA = "0x5A68", Offset = "0x5A68", VA = "0x5A68")]
		public OpToken<IMessage, object> GetShopItemsInfo(ulong ownerId)
		{
		/* --- GHIDRA: GetShopItemsInfo ---
		undefined4
		ServicesNamespace_ShopService__GetShopItemsInfo
		          (undefined4 param1,undefined8 param2,undefined8 param3,undefined4 param4,undefined4 param5
		          )
		
		{
		  int param3_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a55a6d == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Shop_ProtoBuyArtifactCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_ServicesNamespace_ShopService_Request_ProtoBuyArtifactAns__ProtoBuyArtifactCmd___
		              );
		    DAT_ram_00a55a6d = '\x01';
		  }
		  param3_00 = unnamed_function_1417(Protocol_Shop_ProtoBuyArtifactCmd_TypeInfo);
		  *(undefined4 *)(param3_00 + 0x20) = param4;
		  *(undefined8 *)(param3_00 + 0x18) = param3;
		  *(undefined8 *)(param3_00 + 0x10) = param2;
		  uVar1 = ServicesNamespace_ShopService__Request___Il2CppFullySharedGenericType_
		                    (param1,2,param3_00,
		                     Method_ServicesNamespace_ShopService_Request_ProtoBuyArtifactAns__ProtoBuyArtifactCmd___
		                    );
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000668")]
		[Address(RVA = "0x5A69", Offset = "0x5A69", VA = "0x5A69")]
		public OpToken<IMessage, object> BuyArtifact(ulong ownerId, ulong artId, uint destSlotId)
		{
		/* --- GHIDRA: BuyArtifact ---
		undefined4
		ServicesNamespace_ShopService__BuyArtifact
		          (undefined4 param1,undefined8 param2,undefined4 param3,undefined4 param4,undefined4 param5
		          )
		
		{
		  int param3_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a55a6e == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Shop_ProtoMoveArtifactFromUser2ShopCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_ServicesNamespace_ShopService_Request_ProtoMoveArtifactFromUser2ShopAns__ProtoMoveArtifactFromUser2ShopCmd___
		              );
		    DAT_ram_00a55a6e = '\x01';
		  }
		  param3_00 = unnamed_function_1417(Protocol_Shop_ProtoMoveArtifactFromUser2ShopCmd_TypeInfo);
		  *(undefined4 *)(param3_00 + 0x1c) = param4;
		  *(undefined4 *)(param3_00 + 0x18) = param3;
		  *(undefined8 *)(param3_00 + 0x10) = param2;
		  uVar1 = ServicesNamespace_ShopService__Request___Il2CppFullySharedGenericType_
		                    (param1,3,param3_00,
		                     Method_ServicesNamespace_ShopService_Request_ProtoMoveArtifactFromUser2ShopAns__ProtoMoveArtifactFromUser2ShopCmd___
		                    );
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000669")]
		[Address(RVA = "0x5A6A", Offset = "0x5A6A", VA = "0x5A6A")]
		public OpToken<IMessage, object> MoveArtifactFromUserToShop(ulong artId, uint destSlotId, ResourceSet price)
		{
		/* --- GHIDRA: MoveArtifactFromUserToShop ---
		undefined4
		ServicesNamespace_ShopService__MoveArtifactFromUserToShop
		          (undefined4 param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param3_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a55a6f == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Shop_ProtoMoveArtifactFromShop2UserCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_ServicesNamespace_ShopService_Request_ProtoMoveArtifactFromShop2UserAns__ProtoMoveArtifactFromShop2UserCmd___
		              );
		    DAT_ram_00a55a6f = '\x01';
		  }
		  param3_00 = unnamed_function_1417(Protocol_Shop_ProtoMoveArtifactFromShop2UserCmd_TypeInfo);
		  *(undefined4 *)(param3_00 + 0x18) = param3;
		  *(undefined8 *)(param3_00 + 0x10) = param2;
		  uVar1 = ServicesNamespace_ShopService__Request___Il2CppFullySharedGenericType_
		                    (param1,4,param3_00,
		                     Method_ServicesNamespace_ShopService_Request_ProtoMoveArtifactFromShop2UserAns__ProtoMoveArtifactFromShop2UserCmd___
		                    );
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600066A")]
		[Address(RVA = "0x5A6B", Offset = "0x5A6B", VA = "0x5A6B")]
		public OpToken<IMessage, object> MoveArtifactFromShopToUser(ulong artId, uint destSlotId)
		{
		/* --- GHIDRA: MoveArtifactFromShopToUser ---
		undefined4
		ServicesNamespace_ShopService__MoveArtifactFromShopToUser
		          (undefined4 param1,undefined8 param2,undefined4 param3)
		
		{
		  int param3_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a55a70 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Shop_ProtoGetArtifactMinPriceCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_ServicesNamespace_ShopService_Request_ProtoGetArtifactMinPriceAns__ProtoGetArtifactMinPriceCmd___
		              );
		    DAT_ram_00a55a70 = '\x01';
		  }
		  param3_00 = unnamed_function_1417(Protocol_Shop_ProtoGetArtifactMinPriceCmd_TypeInfo);
		  *(undefined8 *)(param3_00 + 0x10) = param2;
		  uVar1 = ServicesNamespace_ShopService__Request___Il2CppFullySharedGenericType_
		                    (param1,5,param3_00,
		                     Method_ServicesNamespace_ShopService_Request_ProtoGetArtifactMinPriceAns__ProtoGetArtifactMinPriceCmd___
		                    );
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600066B")]
		[Address(RVA = "0x5A6C", Offset = "0x5A6C", VA = "0x5A6C")]
		public OpToken<IMessage, object> GetArtifactMinPrice(ulong artId)
		{
		/* --- GHIDRA: GetArtifactMinPrice ---
		undefined4 ServicesNamespace_ShopService__GetArtifactMinPrice(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a55a71 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_ServicesNamespace_ShopService_Request_ProtoGetMarketArtifactsAns___);
		    DAT_ram_00a55a71 = '\x01';
		  }
		  uVar1 = UnityEngine_UI_Extensions_SetPropertyUtility__SetStruct___Il2CppFullySharedGenericStructType_
		                    (param1,6,0,
		                     Method_ServicesNamespace_ShopService_Request_ProtoGetMarketArtifactsAns___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600066C")]
		[Address(RVA = "0x5A6D", Offset = "0x5A6D", VA = "0x5A6D")]
		public OpToken<IMessage, object> GetMarketArtifacts()
		{
		/* --- GHIDRA: GetMarketArtifacts ---
		undefined4
		ServicesNamespace_ShopService__GetMarketArtifacts
		          (undefined4 param1,undefined8 param2,undefined4 param3)
		
		{
		  int param3_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a55a72 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Shop_ProtoGetUserOtherMarketArtifactsCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_ServicesNamespace_ShopService_Request_ProtoGetUserOtherMarketArtifactsAns__ProtoGetUserOtherMarketArtifactsCmd___
		              );
		    DAT_ram_00a55a72 = '\x01';
		  }
		  param3_00 = unnamed_function_1417(Protocol_Shop_ProtoGetUserOtherMarketArtifactsCmd_TypeInfo);
		  *(undefined8 *)(param3_00 + 0x10) = param2;
		  uVar1 = ServicesNamespace_ShopService__Request___Il2CppFullySharedGenericType_
		                    (param1,7,param3_00,
		                     Method_ServicesNamespace_ShopService_Request_ProtoGetUserOtherMarketArtifactsAns__ProtoGetUserOtherMarketArtifactsCmd___
		                    );
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600066D")]
		[Address(RVA = "0x5A6E", Offset = "0x5A6E", VA = "0x5A6E")]
		public OpToken<IMessage, object> GetUserOtherMarketArtifacts(ulong artifactId)
		{
		/* --- GHIDRA: GetUserOtherMarketArtifacts ---
		undefined4
		ServicesNamespace_ShopService__GetUserOtherMarketArtifacts
		          (undefined4 param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param3_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a55a73 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Shop_ProtoBuyMarketArtifactCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_ServicesNamespace_ShopService_Request_ProtoBuyArtifactAns__ProtoBuyMarketArtifactCmd___
		              );
		    DAT_ram_00a55a73 = '\x01';
		  }
		  param3_00 = unnamed_function_1417(Protocol_Shop_ProtoBuyMarketArtifactCmd_TypeInfo);
		  *(undefined4 *)(param3_00 + 0x18) = param3;
		  *(undefined8 *)(param3_00 + 0x10) = param2;
		  uVar1 = ServicesNamespace_ShopService__Request___Il2CppFullySharedGenericType_
		                    (param1,8,param3_00,
		                     Method_ServicesNamespace_ShopService_Request_ProtoBuyArtifactAns__ProtoBuyMarketArtifactCmd___
		                    );
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600066E")]
		[Address(RVA = "0x5A6F", Offset = "0x5A6F", VA = "0x5A6F")]
		public OpToken<IMessage, object> BuyMarketArtifact(ulong artifactId, uint destSlotId)
		{
		/* --- GHIDRA: BuyMarketArtifact ---
		undefined4 ServicesNamespace_ShopService__BuyMarketArtifact(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a55a74 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_ServicesNamespace_ShopService_Request_ProtoEmptyAns___);
		    DAT_ram_00a55a74 = '\x01';
		  }
		  uVar1 = UnityEngine_UI_Extensions_SetPropertyUtility__SetStruct___Il2CppFullySharedGenericStructType_
		                    (param1,9,0,Method_ServicesNamespace_ShopService_Request_ProtoEmptyAns___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600066F")]
		[Address(RVA = "0x5A70", Offset = "0x5A70", VA = "0x5A70")]
		public OpToken<IMessage, object> ExitMarket()
		{
			return null;
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000670")]
		private OpToken<IMessage, object> Request<TAns>(ShopCommands command, IMessage msg) where TAns : IMessage, new()
		{
			return null;
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000671")]
		private OpToken<IMessage, object> Request<TAns, TMsg>(ShopCommands command, IMessage<TMsg> msg) where TAns : IMessage, new() where TMsg : IMessage<TMsg>
		{
			return null;
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000672")]
		[Address(RVA = "0x5A71", Offset = "0x5A71", VA = "0x5A71")]
		public ShopService()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ServiceId ---
		void ServicesNamespace_ShopService__get_ServiceId(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a61 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoArtifactBuyedEvt__TypeInfo);
		    DAT_ram_00a55a61 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoArtifactBuyedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoArtifactBuyedEvt__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x14,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_ArtifactBuyedEvent ---
		void ServicesNamespace_ShopService__add_ArtifactBuyedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a62 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoArtifactBuyedEvt__TypeInfo);
		    DAT_ram_00a55a62 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoArtifactBuyedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoArtifactBuyedEvt__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x14,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_ArtifactBuyedEvent ---
		void ServicesNamespace_ShopService__remove_ArtifactBuyedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a63 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoArtifactMovedEvt__TypeInfo);
		    DAT_ram_00a55a63 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoArtifactMovedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoArtifactMovedEvt__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_ArtifactMovedEvent ---
		void ServicesNamespace_ShopService__add_ArtifactMovedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a64 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoArtifactMovedEvt__TypeInfo);
		    DAT_ram_00a55a64 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoArtifactMovedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoArtifactMovedEvt__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_ArtifactMovedEvent ---
		void ServicesNamespace_ShopService__remove_ArtifactMovedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a65 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoMarketArtifactsAddedEvt__TypeInfo);
		    DAT_ram_00a55a65 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoMarketArtifactsAddedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoMarketArtifactsAddedEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_MarketArtifactsAddedEvent ---
		void ServicesNamespace_ShopService__add_MarketArtifactsAddedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a66 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoMarketArtifactsAddedEvt__TypeInfo);
		    DAT_ram_00a55a66 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoMarketArtifactsAddedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoMarketArtifactsAddedEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_MarketArtifactsAddedEvent ---
		void ServicesNamespace_ShopService__remove_MarketArtifactsAddedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a67 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoMarketArtifactsRemovedEvt__TypeInfo);
		    DAT_ram_00a55a67 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoMarketArtifactsRemovedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoMarketArtifactsRemovedEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x20,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_MarketArtifactsRemovedEvent ---
		void ServicesNamespace_ShopService__add_MarketArtifactsRemovedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a68 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoMarketArtifactsRemovedEvt__TypeInfo);
		    DAT_ram_00a55a68 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoMarketArtifactsRemovedEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoMarketArtifactsRemovedEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x20,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_MarketArtifactsRemovedEvent ---
		void ServicesNamespace_ShopService__remove_MarketArtifactsRemovedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a69 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoMarketOptionsDisabledEvt__TypeInfo);
		    DAT_ram_00a55a69 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ProtoMarketOptionsDisabledEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoMarketOptionsDisabledEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x24,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_MarketOptionsDisabledEvent ---
		void ServicesNamespace_ShopService__add_MarketOptionsDisabledEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a55a6a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoMarketOptionsDisabledEvt__TypeInfo);
		    DAT_ram_00a55a6a = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ProtoMarketOptionsDisabledEvt__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ProtoMarketOptionsDisabledEvt__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x24,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_MarketOptionsDisabledEvent ---
		void ServicesNamespace_ShopService__remove_MarketOptionsDisabledEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  int iVar2;
		  int *param1_00;
		  
		  if (DAT_ram_00a55a6b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_AbstractService_LogEvent_ShopEvents___);
		    Mono_Security_ASN1__get_Item(&Protocol_Shop_ProtoArtifactBuyedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Shop_ProtoArtifactMovedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Shop_ProtoMarketArtifactsAddedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Shop_ProtoMarketArtifactsRemovedEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Shop_ProtoMarketOptionsDisabledEvt_TypeInfo);
		    DAT_ram_00a55a6b = '\x01';
		  }
		  UnityEngine_Purchasing_Extension_AbstractPurchasingModule__BindExtension___Il2CppFullySharedGenericType_
		            (param1,*(undefined4 *)(param2 + 0x10),*(undefined4 *)(param2 + 0x20),
		             Method_Core_Net_AbstractService_LogEvent_ShopEvents___);
		  iVar2 = *(int *)(param2 + 0x10);
		  if (iVar2 != 0) {
		    if (iVar2 == 1) {
		      iVar2 = *(int *)(param1 + 0x14);
		      if (iVar2 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) && (Protocol_Shop_ProtoArtifactBuyedEvt_TypeInfo != *param1_00))
		      {
		        System_Activator__CreateInstance(param1_00,Protocol_Shop_ProtoArtifactBuyedEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    else if (iVar2 == 2) {
		      iVar2 = *(int *)(param1 + 0x18);
		      if (iVar2 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) && (Protocol_Shop_ProtoArtifactMovedEvt_TypeInfo != *param1_00))
		      {
		        System_Activator__CreateInstance(param1_00,Protocol_Shop_ProtoArtifactMovedEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    else if (iVar2 == 3) {
		      iVar2 = *(int *)(param1 + 0x1c);
		      if (iVar2 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) &&
		         (Protocol_Shop_ProtoMarketArtifactsAddedEvt_TypeInfo != *param1_00)) {
		        System_Activator__CreateInstance
		                  (param1_00,Protocol_Shop_ProtoMarketArtifactsAddedEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    else if (iVar2 == 4) {
		      iVar2 = *(int *)(param1 + 0x20);
		      if (iVar2 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) &&
		         (Protocol_Shop_ProtoMarketArtifactsRemovedEvt_TypeInfo != *param1_00)) {
		        System_Activator__CreateInstance
		                  (param1_00,Protocol_Shop_ProtoMarketArtifactsRemovedEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    else {
		      if (iVar2 != 5) {
		        uVar1 = unnamed_function_2232(&System_ArgumentOutOfRangeException_TypeInfo);
		        uVar1 = unnamed_function_1417(uVar1);
		        System_ArgumentNullException___ctor(uVar1,0);
		        param2_00 = unnamed_function_2232
		                              (&Method_ServicesNamespace_ShopService_ServerEventHandler__);
		        func_ii_1050(uVar1,param2_00);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar2 = *(int *)(param1 + 0x24);
		      if (iVar2 == 0) {
		        return;
		      }
		      param1_00 = *(int **)(param2 + 0x20);
		      if ((param1_00 != (int *)0x0) &&
		         (Protocol_Shop_ProtoMarketOptionsDisabledEvt_TypeInfo != *param1_00)) {
		        System_Activator__CreateInstance
		                  (param1_00,Protocol_Shop_ProtoMarketOptionsDisabledEvt_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param1_00,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: Request<object> ---
		int * ServicesNamespace_ShopService__Request_object_
		                (int *param1,undefined4 param2,undefined4 param3,int param4)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (*(int *)(param4 + 0x1c) == 0) {
		    Mono_Security_ASN1__get_Item(&System_Action_SrvCommand__IMessage__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Shop_ShopCommands_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Net_SrvCommand_TypeInfo);
		    if (*(int *)(param4 + 0x1c) == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param4);
		    }
		  }
		  if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		  }
		  param1_00 = (int *)Core_Net_AbstractService__PushCommand
		                               (param1,*(undefined4 *)
		                                        (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x5c) + 4),0);
		  iVar1 = System_IO_Compression_DeflateStreamNative_UnmanagedReadOrWrite__Invoke(param1_00,0);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x110) * 4))
		              (param1_00,*(undefined4 *)(*param1_00 + 0x114));
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    if (*(int *)(Core_Net_SrvCommand_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_SrvCommand_TypeInfo);
		    }
		    iVar1 = Core_Net_SrvCommand___ctor(uVar2,(int)(short)param2,param3,0);
		    local_8 = 0xffffffff;
		    local_c = Protocol_Shop_ShopCommands_TypeInfo;
		    local_4 = param2;
		    uVar2 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    *(undefined4 *)(iVar1 + 0x14) = uVar2;
		    uVar2 = unnamed_function_1417(System_Action_SrvCommand__IMessage__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,*(undefined4 *)(*param1 + 0xec),0);
		    (**(code **)((ulonglong)*(uint *)**(undefined4 **)(param4 + 0x1c) * 4))
		              (iVar1,uVar2,(uint *)**(undefined4 **)(param4 + 0x1c));
		    Core_Net_AbstractService__LogCommandAnswer(param1,iVar1,0);
		  }
		  return param1_00;
		}
		*/


		/* --- GHIDRA: Request<__Il2CppFullySharedGenericType> ---
		undefined4
		ServicesNamespace_ShopService__Request___Il2CppFullySharedGenericType_
		          (undefined4 param1,undefined4 param2,undefined4 param3,int param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  iVar2 = *(int *)(param4 + 0x1c);
		  if (iVar2 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param4);
		    iVar2 = *(int *)(param4 + 0x1c);
		  }
		  uVar1 = UnityEngine_UI_Extensions_SetPropertyUtility__SetStruct___Il2CppFullySharedGenericStructType_
		                    (param1,param2,param3,*(undefined4 *)(iVar2 + 4));
		  return uVar1;
		}
		*/


		/* --- GHIDRA: Request<object, object> ---
		undefined4
		ServicesNamespace_ShopService__Request_object__object_
		          (undefined4 param1,undefined4 param2,undefined4 param3,int param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  iVar2 = *(int *)(param4 + 0x1c);
		  if (iVar2 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param4);
		    iVar2 = *(int *)(param4 + 0x1c);
		  }
		  uVar1 = (**(code **)((ulonglong)**(uint **)(iVar2 + 4) * 4))
		                    (param1,param2,param3,*(uint **)(iVar2 + 4));
		  return uVar1;
		}
		*/


		/* --- GHIDRA: Request<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType> ---
		int * ServicesNamespace_ShopService__Request___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                (undefined4 param1,int param2,int param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  
		  puVar3 = *(undefined4 **)(param3 + 0x1c);
		  if (puVar3 == (undefined4 *)0x0) {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    puVar3 = *(undefined4 **)(param3 + 0x1c);
		    if (puVar3 == (undefined4 *)0x0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param3);
		      puVar3 = *(undefined4 **)(param3 + 0x1c);
		    }
		  }
		  piVar1 = (int *)UnityEngine_GameObject__GetComponent_object_(param1,*puVar3);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(param2,0,0);
		  if (iVar2 != 0) {
		    piVar1[4] = param2;
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x108) * 4))
		              (piVar1,0,*(undefined4 *)(*piVar1 + 0x10c));
		  }
		  return piVar1;
		}
		*/

}
