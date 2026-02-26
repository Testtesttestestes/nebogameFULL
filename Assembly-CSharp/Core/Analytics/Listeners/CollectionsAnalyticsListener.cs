using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012CA RID: 4810
	[Token(Token = "0x20012CA")]
	public class CollectionsAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x1700172D RID: 5933
		// (get) Token: 0x0600725B RID: 29275 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700172D")]
		protected override string Theme
		{
			[Token(Token = "0x600725B")]
			[Address(RVA = "0xBC64", Offset = "0xBC64", VA = "0xBC64", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600725C RID: 29276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600725C")]
		[Address(RVA = "0xBC65", Offset = "0xBC65", VA = "0xBC65", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_CollectionsAnalyticsListener__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a595b0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CollectionsScope_CollectionsEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_CollectionsAnalyticsListener_CollectionImprovedEvent__
		              );
		    DAT_ram_00a595b0 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x58);
		  param1_00 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_CollectionsScope_CollectionsEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_CollectionsAnalyticsListener_CollectionImprovedEvent__,
		             0);
		  iVar1 = func_ii_7048(param1_00,uVar2,0);
		  uVar2 = System_Action_CollectionsScope_CollectionsEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_CollectionsScope_CollectionsEventArgs__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 8) = iVar3;
		  uVar2 = System_Action_CollectionsScope_CollectionsEventArgs__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,System_Action_CollectionsScope_CollectionsEventArgs__TypeInfo);
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

		// Token: 0x0600725D RID: 29277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600725D")]
		[Address(RVA = "0xBC66", Offset = "0xBC66", VA = "0xBC66", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_CollectionsAnalyticsListener__Deinit
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *param1_01;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a595b1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21405);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21409);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21408);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21406);
		    DAT_ram_00a595b1 = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  iVar2 = System_Xml_XsdCachingReader__get_Name(*(undefined4 *)(param2 + 0x10),0);
		  local_4 = *(undefined4 *)(iVar2 + 0xc);
		  uVar3 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  func_ii_2946(param1_00,StringLiteral_21405,uVar3,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_8 = *(undefined4 *)(*(int *)(param2 + 0x10) + 0x1c);
		  uVar3 = func_ii_1081(DAT_ram_00a66958,&local_8);
		  func_ii_2946(param1_00,StringLiteral_21408,uVar3,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  uVar3 = System_Xml_XsdCachingReader__get_Name(*(undefined4 *)(param2 + 0x10),0);
		  uVar3 = Core_Extensions_Dict_CollectionRankInfoDicExt__GetAvatarRibbonAssetId(uVar3,0);
		  func_ii_2946(param1_00,StringLiteral_21409,uVar3,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  param1_01 = (int *)param1[2];
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar3 = StringLiteral_21406;
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd8);
		        goto code_r0x81033216;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_01,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81033216:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_01,uVar4,uVar3,param1_00,puVar5[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600725E RID: 29278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600725E")]
		[Address(RVA = "0xBC67", Offset = "0xBC67", VA = "0xBC67")]
		private void CollectionImprovedEvent(CollectionsScope.CollectionsEventArgs e)
		{
		}

		// Token: 0x0600725F RID: 29279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600725F")]
		[Address(RVA = "0xBC68", Offset = "0xBC68", VA = "0xBC68")]
		public CollectionsAnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Listeners_CollectionsAnalyticsListener___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a595b2 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_21850);
		    DAT_ram_00a595b2 = '\x01';
		  }
		  return StringLiteral_21850;
		}
		*/

		}

		// Token: 0x04003BF6 RID: 15350
		[Token(Token = "0x4003BF6")]
		private const string COLLECTION_IMPROVED = "collection_improved";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_CollectionsAnalyticsListener__get_Theme(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a595af == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CollectionsScope_CollectionsEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_CollectionsAnalyticsListener_CollectionImprovedEvent__
		              );
		    DAT_ram_00a595af = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x58);
		  param1_00 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_CollectionsScope_CollectionsEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_CollectionsAnalyticsListener_CollectionImprovedEvent__,
		             0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(param1_00,uVar2,0);
		  uVar2 = System_Action_CollectionsScope_CollectionsEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_CollectionsScope_CollectionsEventArgs__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 8) = iVar3;
		  uVar2 = System_Action_CollectionsScope_CollectionsEventArgs__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,System_Action_CollectionsScope_CollectionsEventArgs__TypeInfo);
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
