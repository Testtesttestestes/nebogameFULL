using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012D1 RID: 4817
	[Token(Token = "0x20012D1")]
	public class GiftsAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001735 RID: 5941
		// (get) Token: 0x06007287 RID: 29319 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001735")]
		protected override string Theme
		{
			[Token(Token = "0x6007287")]
			[Address(RVA = "0xBC90", Offset = "0xBC90", VA = "0xBC90", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007288 RID: 29320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007288")]
		[Address(RVA = "0xBC91", Offset = "0xBC91", VA = "0xBC91", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_GiftsAnalyticsListener__Init(int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a595d1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26155);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24201);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24203);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24202);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27638);
		    DAT_ram_00a595d1 = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  piVar5 = *(int **)(param2 + 0xc);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x81035ad5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81035ad5:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  iVar6 = Core_Extensions_Dict_DictExt__GetClanBuildingLevel(uVar3,*(undefined4 *)(param2 + 0x18),0)
		  ;
		  local_4 = *(undefined4 *)(iVar6 + 0xc);
		  uVar3 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  func_ii_2946(param1_00,StringLiteral_24201,uVar3,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  uVar3 = Core_Extensions_Dict_SocialGiftDicExt__GetIconAssetId(iVar6,0);
		  func_ii_2946(param1_00,StringLiteral_24203,uVar3,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  Gameplay_Boss_Model_BossInfo_BossAttackOption_BossAttackOptionVariant__get_Price
		            (param1,param1_00,*(undefined4 *)(iVar6 + 0x10),StringLiteral_26155,0);
		  local_10 = *(undefined8 *)(param2 + 0x10);
		  uVar3 = func_ii_1081(DAT_ram_00a66968,&local_10);
		  func_ii_2946(param1_00,StringLiteral_27638,uVar3,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  piVar5 = (int *)param1[2];
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar3 = StringLiteral_24202;
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x81035c2f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81035c2f:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar5,uVar4,uVar3,param1_00,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007289 RID: 29321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007289")]
		[Address(RVA = "0xBC92", Offset = "0xBC92", VA = "0xBC92")]
		private void GiftSendEvent(GiftsScope.GiftsEventArgs e)
		{
		/* --- GHIDRA: GiftSendEvent ---
		void Core_Analytics_Listeners_GiftsAnalyticsListener__GiftSendEvent(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a595d2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GiftsScope_GiftsEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_GiftsAnalyticsListener_GiftSendEvent__);
		    DAT_ram_00a595d2 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x80);
		  param1_00 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_GiftsScope_GiftsEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_GiftsAnalyticsListener_GiftSendEvent__,0);
		  iVar1 = func_ii_7048(param1_00,uVar2,0);
		  uVar2 = System_Action_GiftsScope_GiftsEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_GiftsScope_GiftsEventArgs__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 8) = iVar3;
		  uVar2 = System_Action_GiftsScope_GiftsEventArgs__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,System_Action_GiftsScope_GiftsEventArgs__TypeInfo);
		  if (iVar4 != 0) {
		    return;
		  }
		  System_Activator__CreateInstance(iVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600728A RID: 29322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600728A")]
		[Address(RVA = "0xBC93", Offset = "0xBC93", VA = "0xBC93", Slot = "11")]
		protected override void Deinit()
		{
		}

		// Token: 0x0600728B RID: 29323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600728B")]
		[Address(RVA = "0xBC94", Offset = "0xBC94", VA = "0xBC94")]
		public GiftsAnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Listeners_GiftsAnalyticsListener___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a595d3 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_24210);
		    DAT_ram_00a595d3 = '\x01';
		  }
		  return StringLiteral_24210;
		}
		*/

		}

		// Token: 0x04003C05 RID: 15365
		[Token(Token = "0x4003C05")]
		private const string GIFT_SEND = "gift_send";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_GiftsAnalyticsListener__get_Theme(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a595d0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GiftsScope_GiftsEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_GiftsAnalyticsListener_GiftSendEvent__);
		    DAT_ram_00a595d0 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x80);
		  param1_00 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_GiftsScope_GiftsEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_GiftsAnalyticsListener_GiftSendEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(param1_00,uVar2,0);
		  uVar2 = System_Action_GiftsScope_GiftsEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_GiftsScope_GiftsEventArgs__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 8) = iVar3;
		  uVar2 = System_Action_GiftsScope_GiftsEventArgs__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,System_Action_GiftsScope_GiftsEventArgs__TypeInfo);
		  if (iVar4 != 0) {
		    return;
		  }
		  System_Activator__CreateInstance(iVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
