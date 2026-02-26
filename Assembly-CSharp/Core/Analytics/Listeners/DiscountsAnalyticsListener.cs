using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012CF RID: 4815
	[Token(Token = "0x20012CF")]
	public class DiscountsAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001733 RID: 5939
		// (get) Token: 0x0600727A RID: 29306 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001733")]
		protected override string Theme
		{
			[Token(Token = "0x600727A")]
			[Address(RVA = "0xBC83", Offset = "0xBC83", VA = "0xBC83", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600727B RID: 29307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600727B")]
		[Address(RVA = "0xBC84", Offset = "0xBC84", VA = "0xBC84", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_DiscountsAnalyticsListener__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a595c6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_DiscountsScope_DiscountClickEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_DiscountsAnalyticsListener_DiscountClickEvent__);
		    DAT_ram_00a595c6 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x4c);
		  param1_00 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_DiscountsScope_DiscountClickEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_DiscountsAnalyticsListener_DiscountClickEvent__,0);
		  iVar1 = func_ii_7048(param1_00,uVar2,0);
		  uVar2 = System_Action_DiscountsScope_DiscountClickEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_DiscountsScope_DiscountClickEventArgs__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 8) = iVar3;
		  uVar2 = System_Action_DiscountsScope_DiscountClickEventArgs__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,System_Action_DiscountsScope_DiscountClickEventArgs__TypeInfo);
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

		// Token: 0x0600727C RID: 29308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600727C")]
		[Address(RVA = "0xBC85", Offset = "0xBC85", VA = "0xBC85", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_DiscountsAnalyticsListener__Deinit
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  int iVar5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a595c7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22690);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22688);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22689);
		    DAT_ram_00a595c7 = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  local_4 = *(undefined4 *)(*(int *)(*(int *)(param2 + 0x10) + 8) + 0xc);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  func_ii_2946(param1_00,StringLiteral_22689,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  uVar2 = Core_Extensions_Dict_DiscountsDicExt__GetIconAssetId
		                    (*(undefined4 *)(*(int *)(param2 + 0x10) + 8),0);
		  func_ii_2946(param1_00,StringLiteral_22690,uVar2,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar2 = StringLiteral_22688;
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x81034f71;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81034f71:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar3,uVar2,param1_00,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600727D RID: 29309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600727D")]
		[Address(RVA = "0xBC86", Offset = "0xBC86", VA = "0xBC86")]
		private void DiscountClickEvent(DiscountsScope.DiscountClickEventArgs e)
		{
		}

		// Token: 0x0600727E RID: 29310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600727E")]
		[Address(RVA = "0xBC87", Offset = "0xBC87", VA = "0xBC87")]
		public DiscountsAnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Listeners_DiscountsAnalyticsListener___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a595c8 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_23324);
		    DAT_ram_00a595c8 = '\x01';
		  }
		  return StringLiteral_23324;
		}
		*/

		}

		// Token: 0x04003BFF RID: 15359
		[Token(Token = "0x4003BFF")]
		private const string DISCOUNT_CLICK = "discount_click";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_DiscountsAnalyticsListener__get_Theme(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a595c5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_DiscountsScope_DiscountClickEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_DiscountsAnalyticsListener_DiscountClickEvent__);
		    DAT_ram_00a595c5 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x4c);
		  param1_00 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_DiscountsScope_DiscountClickEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_DiscountsAnalyticsListener_DiscountClickEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(param1_00,uVar2,0);
		  uVar2 = System_Action_DiscountsScope_DiscountClickEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_DiscountsScope_DiscountClickEventArgs__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 8) = iVar3;
		  uVar2 = System_Action_DiscountsScope_DiscountClickEventArgs__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,System_Action_DiscountsScope_DiscountClickEventArgs__TypeInfo);
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
