using System;
using AssetContent.Loaders;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gameplay.UserInterface.Menu.ExternalLinks.View
{
	// Token: 0x020003E2 RID: 994
	[Token(Token = "0x20003E2")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Button))]
	public class ExternalLinkButtonView : MonoBehaviour
	{
		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06001743 RID: 5955 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001744 RID: 5956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000408")]
		public OptionsMenuButton Data
		{
			[Token(Token = "0x6001743")]
			[Address(RVA = "0x6902", Offset = "0x6902", VA = "0x6902")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001744")]
			[Address(RVA = "0x1F22", Offset = "0x1F22", VA = "0x1F22")]
			set
			{
			}
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001745")]
		[Address(RVA = "0x6903", Offset = "0x6903", VA = "0x6903")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_UserInterface_Menu_ExternalLinks_View_ExternalLinkButtonView__Start
		               (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a59897 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_Button___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Menu_ExternalLinks_View_ExternalLinkButtonView_OnClick__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a59897 = '\x01';
		  }
		  iVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_Button___);
		  param1_01 = *(undefined4 *)(iVar1 + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_UserInterface_Menu_ExternalLinks_View_ExternalLinkButtonView_OnClick__,
		             0);
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001746 RID: 5958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001746")]
		[Address(RVA = "0x6904", Offset = "0x6904", VA = "0x6904")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_UserInterface_Menu_ExternalLinks_View_ExternalLinkButtonView__OnDestroy
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59898 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_OptionsMenuButton__Invoke__);
		    DAT_ram_00a59898 = '\x01';
		  }
		  func_ii_16397(*(undefined4 *)(param1 + 0x20),*(undefined4 *)(param1 + 0x10),
		                Method_UnityEngine_Events_UnityEvent_OptionsMenuButton__Invoke__);
		  return;
		}
		*/

		}

		// Token: 0x06001747 RID: 5959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001747")]
		[Address(RVA = "0x6905", Offset = "0x6905", VA = "0x6905")]
		private void OnClick()
		{
		/* --- GHIDRA: OnClick ---
		void Gameplay_UserInterface_Menu_ExternalLinks_View_ExternalLinkButtonView__OnClick
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59899 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_OptionsMenuButton___ctor__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityEvent_OptionsMenuButton__TypeInfo);
		    DAT_ram_00a59899 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityEvent_OptionsMenuButton__TypeInfo);
		  Sirenix_Serialization_UnityEventFormatter_object___GetUninitializedObject
		            (param1_00,Method_UnityEngine_Events_UnityEvent_OptionsMenuButton___ctor__);
		  *(undefined4 *)(param1 + 0x20) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001748 RID: 5960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001748")]
		[Address(RVA = "0x6906", Offset = "0x6906", VA = "0x6906")]
		public ExternalLinkButtonView()
		{
		}

		// Token: 0x04000C5B RID: 3163
		[Token(Token = "0x4000C5B")]
		[FieldOffset(Offset = "0x10")]
		private OptionsMenuButton _data;

		// Token: 0x04000C5C RID: 3164
		[Token(Token = "0x4000C5C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameImageLoader _gameImageLoader;

		// Token: 0x04000C5D RID: 3165
		[Token(Token = "0x4000C5D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04000C5E RID: 3166
		[Token(Token = "0x4000C5E")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04000C5F RID: 3167
		[Token(Token = "0x4000C5F")]
		[FieldOffset(Offset = "0x20")]
		[Space(10f)]
		public UnityEvent<OptionsMenuButton> onClick;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Data ---
		void Gameplay_UserInterface_Menu_ExternalLinks_View_ExternalLinkButtonView__get_Data
		               (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a59896 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_Button___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Menu_ExternalLinks_View_ExternalLinkButtonView_OnClick__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a59896 = '\x01';
		  }
		  iVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_Button___);
		  param1_01 = *(undefined4 *)(iVar1 + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_UserInterface_Menu_ExternalLinks_View_ExternalLinkButtonView_OnClick__,
		             0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

}
