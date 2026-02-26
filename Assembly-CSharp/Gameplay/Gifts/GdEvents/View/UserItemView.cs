using System;
using System.Runtime.CompilerServices;
using AssetContent.Loaders;
using Core.Data;
using Gameplay.Aprs.View;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Gifts.GdEvents.View
{
	// Token: 0x02000712 RID: 1810
	[Token(Token = "0x2000712")]
	public class UserItemView : MonoBehaviour
	{
		// Token: 0x1400015E RID: 350
		// (add) Token: 0x06002B4F RID: 11087 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002B50 RID: 11088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400015E")]
		public event Action<UserData> SelectEvent
		{
			[Token(Token = "0x6002B4F")]
			[Address(RVA = "0x7BE9", Offset = "0x7BE9", VA = "0x7BE9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002B50")]
			[Address(RVA = "0x7BEA", Offset = "0x7BEA", VA = "0x7BEA")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06002B51 RID: 11089 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000846")]
		public UserData Data
		{
			[Token(Token = "0x6002B51")]
			[Address(RVA = "0x7BEB", Offset = "0x7BEB", VA = "0x7BEB")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002B52 RID: 11090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B52")]
		[Address(RVA = "0x7BEC", Offset = "0x7BEC", VA = "0x7BEC")]
		public void SetData(UserData user)
		{
		/* --- GHIDRA: SetData ---
		void Gameplay_Gifts_GdEvents_View_UserItemView__SetData(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a237 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Gifts_GdEvents_View_UserItemView_Call__);
		    DAT_ram_00a5a237 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,Method_Gameplay_Gifts_GdEvents_View_UserItemView_Call__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06002B53 RID: 11091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B53")]
		[Address(RVA = "0x7BED", Offset = "0x7BED", VA = "0x7BED")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Gifts_GdEvents_View_UserItemView__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a238 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Gifts_GdEvents_View_UserItemView_Call__);
		    DAT_ram_00a5a238 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x24) = 0;
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,Method_Gameplay_Gifts_GdEvents_View_UserItemView_Call__,0);
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06002B54 RID: 11092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B54")]
		[Address(RVA = "0x7BEE", Offset = "0x7BEE", VA = "0x7BEE")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002B55 RID: 11093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B55")]
		[Address(RVA = "0x7BEF", Offset = "0x7BEF", VA = "0x7BEF")]
		private void Call()
		{
		}

		// Token: 0x06002B56 RID: 11094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B56")]
		[Address(RVA = "0x7BF0", Offset = "0x7BF0", VA = "0x7BF0")]
		public void SetButtonEnabled(bool value)
		{
		}

		// Token: 0x06002B57 RID: 11095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B57")]
		[Address(RVA = "0x7BF1", Offset = "0x7BF1", VA = "0x7BF1")]
		public UserItemView()
		{
		}

		// Token: 0x040017BB RID: 6075
		[Token(Token = "0x40017BB")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private AprViewSmall _apr;

		// Token: 0x040017BC RID: 6076
		[Token(Token = "0x40017BC")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _nick;

		// Token: 0x040017BD RID: 6077
		[Token(Token = "0x40017BD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameRawImageLoader _cult;

		// Token: 0x040017BE RID: 6078
		[Token(Token = "0x40017BE")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _button;

		// Token: 0x040017C0 RID: 6080
		[Token(Token = "0x40017C0")]
		[FieldOffset(Offset = "0x24")]
		public UserData _data;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_SelectEvent ---
		void Gameplay_Gifts_GdEvents_View_UserItemView__add_SelectEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a235 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UserData__TypeInfo);
		    DAT_ram_00a5a235 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_UserData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_UserData__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: get_Data ---
		void Gameplay_Gifts_GdEvents_View_UserItemView__get_Data(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  undefined4 param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5a236 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    DAT_ram_00a5a236 = '\x01';
		  }
		  *(int *)(param1 + 0x24) = param2;
		  iVar3 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x138) * 4))
		            (*(int **)(param1 + 0x10),*(undefined4 *)(param2 + 0x38),*(undefined4 *)(iVar3 + 0x13c))
		  ;
		  piVar2 = *(int **)(param1 + 0x14);
		  uVar1 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator(param2,0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  param1_00 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = Gameplay_Boss_View_CaptainTab_BossSkillInfoView__set_DominateCultDescription
		                    (*(undefined4 *)(param2 + 0x4c),0);
		  Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		            (param1_00,uVar1,
		             Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		            );
		  return;
		}
		*/

}
