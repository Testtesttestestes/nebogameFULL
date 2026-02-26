using System;
using Il2CppDummyDll;

namespace UI.Rewards.Renderers
{
	// Token: 0x020001A4 RID: 420
	[Token(Token = "0x20001A4")]
	internal class ArtifactRewardRenderWithoutTakeSell : ArtifactRewardRender
	{
		// Token: 0x06000B84 RID: 2948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B84")]
		[Address(RVA = "0x5E9E", Offset = "0x5E9E", VA = "0x5E9E", Slot = "11")]
		protected override void ValidateVisibleButtons()
		{
		/* --- GHIDRA: ValidateVisibleButtons ---
		void UI_Rewards_Renderers_ArtifactRewardRenderWithoutTakeSell__ValidateVisibleButtons
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a59a25 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a59a25 = '\x01';
		  }
		  UI_Rewards_Renderers_ArtifactRewardRender__get_SellAllBtn(param1,param1);
		  uVar2 = *(undefined4 *)(param1 + 0x3c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		  if (iVar1 != 0) {
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x3c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,0,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B85")]
		[Address(RVA = "0x5E9F", Offset = "0x5E9F", VA = "0x5E9F", Slot = "8")]
		protected override void HandleRewardChanged()
		{
		/* --- GHIDRA: HandleRewardChanged ---
		void UI_Rewards_Renderers_ArtifactRewardRenderWithoutTakeSell__HandleRewardChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  UI_Rewards_Renderers_ArtifactRewardRender__Dispose(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x5EA0", Offset = "0x5EA0", VA = "0x5EA0")]
		public ArtifactRewardRenderWithoutTakeSell()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Rewards_Renderers_ArtifactRewardRenderWithoutTakeSell___ctor
		               (undefined8 *param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  undefined1 auStack_30 [8];
		  undefined8 local_28;
		  undefined4 local_1c;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined4 uStack_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59a26 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Start_ArtifactViewAnimationHandler__HandleAnimation_d__0___
		              );
		    DAT_ram_00a59a26 = '\x01';
		  }
		  local_8 = 0;
		  local_18 = 0;
		  local_1c = 0xffffffff;
		  _local_10 = CONCAT44(param4,param3);
		  if (*(int *)(
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Start_ArtifactViewAnimationHandler__HandleAnimation_d__0___
		              + 0x1c) == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference
		              (
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_Start_ArtifactViewAnimationHandler__HandleAnimation_d__0___
		              );
		  }
		  UI_Rewards_Renderers_ArtifactViewAnimationHandler___ctor(&local_1c,auStack_30);
		  Core_Analytics_Okg_OkgAnalytics__ApplyLog_d__48__MoveNext(&local_28,&local_18,0);
		  *param1 = local_28;
		  return;
		}
		*/

		}
	}
}
