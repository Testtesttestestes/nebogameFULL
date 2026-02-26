using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Data;
using Gameplay.WorldAxis.Office.View.Schedule;
using Il2CppDummyDll;
using Protocol.Dic;
using UI;
using UI.ToolTip;
using UI.ToolTip.Implementations;
using UnityEngine;
using UnityEngine.UI;
using Utils.Timers;

namespace Gameplay.Isles.Axis.View
{
	// Token: 0x02000D04 RID: 3332
	[Token(Token = "0x2000D04")]
	public class ColossusInWorldView : MonoBehaviourWithStates<ColossusInWorldView.State>, IToolTipDataProvider
	{
		// Token: 0x17001078 RID: 4216
		// (get) Token: 0x06005152 RID: 20818 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001078")]
		private DelayedCall ShieldTimer
		{
			[Token(Token = "0x6005152")]
			[Address(RVA = "0x9F31", Offset = "0x9F31", VA = "0x9F31")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001079 RID: 4217
		// (get) Token: 0x06005153 RID: 20819 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001079")]
		private Dictionary<ColossusBattleData.State, Sprite> SwordsIconByStateDict
		{
			[Token(Token = "0x6005153")]
			[Address(RVA = "0x9F32", Offset = "0x9F32", VA = "0x9F32")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700107A RID: 4218
		// (get) Token: 0x06005154 RID: 20820 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005155 RID: 20821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700107A")]
		public ColossusBattleData ColossusData
		{
			[Token(Token = "0x6005154")]
			[Address(RVA = "0x9F33", Offset = "0x9F33", VA = "0x9F33")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005155")]
			[Address(RVA = "0x9F34", Offset = "0x9F34", VA = "0x9F34")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700107B RID: 4219
		// (get) Token: 0x06005156 RID: 20822 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700107B")]
		public GameAssetViewSpriteRenderer AssetViewSpriteRenderer
		{
			[Token(Token = "0x6005156")]
			[Address(RVA = "0x9F35", Offset = "0x9F35", VA = "0x9F35")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001ED RID: 493
		// (add) Token: 0x06005157 RID: 20823 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005158 RID: 20824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001ED")]
		public event Action<ColossusBattleData> ClickedEvent
		{
			[Token(Token = "0x6005157")]
			[Address(RVA = "0x9F36", Offset = "0x9F36", VA = "0x9F36")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005158")]
			[Address(RVA = "0x9F37", Offset = "0x9F37", VA = "0x9F37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06005159 RID: 20825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005159")]
		[Address(RVA = "0x9F38", Offset = "0x9F38", VA = "0x9F38")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Isles_Axis_View_ColossusInWorldView__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58cfb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameAssetViewSpriteRenderer__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_Axis_View_ColossusInWorldView_AssetViewClickedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_Axis_View_ColossusInWorldView_ButtonClickedEventHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a58cfb = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x1c);
		  uVar1 = unnamed_function_1417(System_Action_GameAssetViewSpriteRenderer__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Isles_Axis_View_ColossusInWorldView_AssetViewClickedEventHandler__,0);
		  AssetContent_GameAssetViewSpriteRenderer__add_ClickedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x34) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Isles_Axis_View_ColossusInWorldView_ButtonClickedEventHandler__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar1 = Gameplay_Isles_Axis_View_AxisIsleView___ctor(param1,param1);
		  Utils_Timers_DelayedCall__DelayedCallAsync(uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600515A RID: 20826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600515A")]
		[Address(RVA = "0x9F39", Offset = "0x9F39", VA = "0x9F39")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Isles_Axis_View_ColossusInWorldView__OnDestroy
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x44);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x40),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600515B RID: 20827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600515B")]
		[Address(RVA = "0x9F3A", Offset = "0x9F3A", VA = "0x9F3A")]
		private void AssetViewClickedEventHandler(GameAssetViewSpriteRenderer gameAssetView)
		{
		/* --- GHIDRA: AssetViewClickedEventHandler ---
		void Gameplay_Isles_Axis_View_ColossusInWorldView__AssetViewClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x44);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x40),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600515C RID: 20828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600515C")]
		[Address(RVA = "0x9F3B", Offset = "0x9F3B", VA = "0x9F3B")]
		private void ButtonClickedEventHandler()
		{
		/* --- GHIDRA: ButtonClickedEventHandler ---
		void Gameplay_Isles_Axis_View_ColossusInWorldView__ButtonClickedEventHandler
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  float param2_00;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a58cfc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_Axis_View_ColossusInWorldView_GetAttackCostTooltip__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_Axis_View_ColossusInWorldView_GetShieldTooltipData__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ColossusBattleData_State__Sprite__get_Item__
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_BaseToolTipData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_ColossusInWorldView_State__set_CurrentState__);
		    DAT_ram_00a58cfc = '\x01';
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,1,
		             Method_UI_MonoBehaviourWithStates_ColossusInWorldView_State__set_CurrentState__);
		  *(int *)(param1 + 0x40) = param2;
		  uVar1 = Gameplay_Isles_Axis_View_AxisIsleView___ctor(param1,param1);
		  Utils_Timers_DelayedCall__SetDelay(uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x1c);
		  uVar1 = Core_Extensions_Dict_ColossusDicExt__GetIconFilter(*(undefined4 *)(param2 + 0x10),0);
		  AssetContent_GameAssetViewSpriteRenderer__get_AssetId(uVar2,uVar1,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x24),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(*(int *)(param2 + 8) != 0),0);
		  uVar2 = *(undefined4 *)(param1 + 0x24);
		  uVar1 = Gameplay_Isles_Axis_View_ColossusInWorldView__get_ShieldTimer(param1,param1);
		  uVar1 = GAFInternal_Reader_GAFReader__OpenTag
		                    (uVar1,*(undefined4 *)(param2 + 8),
		                     Method_System_Collections_Generic_Dictionary_ColossusBattleData_State__Sprite__get_Item__
		                    );
		  Core_Extensions_SpriteAtlasExt__TryGetSprite(uVar2,uVar1,0);
		  iVar3 = *(int *)(param1 + 0x2c);
		  uVar1 = unnamed_function_1417(System_Func_BaseToolTipData__TypeInfo);
		  func_ii_19797(uVar1,param1,
		                Method_Gameplay_Isles_Axis_View_ColossusInWorldView_GetShieldTooltipData__,0);
		  *(undefined4 *)(iVar3 + 0x10) = uVar1;
		  iVar3 = *(int *)(param1 + 0x30);
		  uVar1 = unnamed_function_1417(System_Func_BaseToolTipData__TypeInfo);
		  func_ii_19797(uVar1,param1,
		                Method_Gameplay_Isles_Axis_View_ColossusInWorldView_GetAttackCostTooltip__,0);
		  *(undefined4 *)(iVar3 + 0x10) = uVar1;
		  iVar3 = Core_Data_ColossusBattleData__set_ShieldBacktime(param2,0);
		  if (iVar3 != 0) {
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x2c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    UI_Elements_RightPanel_TitleWithLevel__set_Level
		              (*(undefined4 *)(param1 + 0x28),*(undefined4 *)(param2 + 0x1c),0);
		    uVar1 = Gameplay_Isles_Axis_View_AxisIsleView___ctor(param1,param1);
		    param2_00 = func_ii_7103(*(undefined4 *)(param2 + 0x1c),0);
		    Utils_Timers_DelayedCall___ctor(uVar1,param2_00,0);
		    return;
		  }
		  UI_Elements_RightPanel_TitleWithLevel__set_Level
		            (*(undefined4 *)(param1 + 0x28),*(undefined4 *)(param2 + 0x18),0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x2c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  return;
		}
		*/

		}

		// Token: 0x0600515D RID: 20829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600515D")]
		[Address(RVA = "0x9F3C", Offset = "0x9F3C", VA = "0x9F3C")]
		public void Init(ColossusBattleData data)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Isles_Axis_View_ColossusInWorldView__Init(int param1,undefined4 param2)
		
		{
		  Gameplay_Isles_Axis_View_ColossusInWorldView__ButtonClickedEventHandler
		            (param1,*(undefined4 *)(param1 + 0x40),param1);
		  return;
		}
		*/

		/* --- GHIDRA: Init ---
		void Gameplay_Isles_Axis_View_ColossusInWorldView__Init(int param1,undefined4 param2)
		
		{
		  Gameplay_Isles_Axis_View_ColossusInWorldView__ButtonClickedEventHandler
		            (param1,*(undefined4 *)(param1 + 0x40),param1);
		  return;
		}
		*/

		}

		// Token: 0x0600515E RID: 20830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600515E")]
		[Address(RVA = "0x9F3D", Offset = "0x9F3D", VA = "0x9F3D")]
		public void Init(ColossusDic dic)
		{
		}

		// Token: 0x0600515F RID: 20831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600515F")]
		[Address(RVA = "0x9F3E", Offset = "0x9F3E", VA = "0x9F3E")]
		private void UpdateState()
		{
		/* --- GHIDRA: UpdateState ---
		int Gameplay_Isles_Axis_View_ColossusInWorldView__UpdateState(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58cfe == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_ClanData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_string___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_string__set_Data__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_ClanData__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_ClanData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17791);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12530);
		    DAT_ram_00a58cfe = '\x01';
		  }
		  if ((*(int *)(param1 + 0x40) != 0) && (*(int *)(*(int *)(param1 + 0x40) + 0x14) != 0)) {
		    iVar1 = unnamed_function_1417(UI_ToolTip_ToolTipData_ClanData__TypeInfo);
		    System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		              (iVar1,StringLiteral_12530,Method_UI_ToolTip_ToolTipData_ClanData___ctor__);
		    *(undefined4 *)(iVar1 + 0x1c) = *(undefined4 *)(*(int *)(param1 + 0x40) + 0x14);
		    return iVar1;
		  }
		  iVar1 = unnamed_function_1417(UI_ToolTip_ToolTipData_string__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (iVar1,0,Method_UI_ToolTip_ToolTipData_string___ctor__);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17791,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar1 + 0x1c) = uVar2;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06005160 RID: 20832 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005160")]
		[Address(RVA = "0x9F3F", Offset = "0x9F3F", VA = "0x9F3F", Slot = "5")]
		public BaseToolTipData GetData()
		{
		/* --- GHIDRA: GetData ---
		int Gameplay_Isles_Axis_View_ColossusInWorldView__GetData(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58cff == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_ToolTip_Implementations_View_Misc_BacktimeTitleToolTipView_BacktimeTitleArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ToolTip_ToolTipData_BacktimeTitleToolTipView_BacktimeTitleArgs___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ToolTip_ToolTipData_BacktimeTitleToolTipView_BacktimeTitleArgs__set_Data__
		              );
		    Mono_Security_ASN1__get_Item
		              (&UI_ToolTip_ToolTipData_BacktimeTitleToolTipView_BacktimeTitleArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12524);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17792);
		    DAT_ram_00a58cff = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (UI_ToolTip_ToolTipData_BacktimeTitleToolTipView_BacktimeTitleArgs__TypeInfo
		                        );
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (param1_00,StringLiteral_12524,
		             Method_UI_ToolTip_ToolTipData_BacktimeTitleToolTipView_BacktimeTitleArgs___ctor__);
		  iVar1 = unnamed_function_1417
		                    (
		                    UI_ToolTip_Implementations_View_Misc_BacktimeTitleToolTipView_BacktimeTitleArgs_TypeInfo
		                    );
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17792,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar1 + 8) = uVar2;
		  *(undefined4 *)(iVar1 + 0xc) = *(undefined4 *)(*(int *)(param1 + 0x28) + 0x18);
		  *(int *)(param1_00 + 0x1c) = iVar1;
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06005161 RID: 20833 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005161")]
		[Address(RVA = "0x9F40", Offset = "0x9F40", VA = "0x9F40")]
		private BaseToolTipData GetShieldTooltipData()
		{
		/* --- GHIDRA: GetShieldTooltipData ---
		int Gameplay_Isles_Axis_View_ColossusInWorldView__GetShieldTooltipData(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58d00 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_string___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_string__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26152);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17790);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2556);
		    DAT_ram_00a58d00 = '\x01';
		  }
		  if (*(int *)(*(int *)(param1 + 0x40) + 8) == 3) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 600);
		          goto code_r0x80f9c97e;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x33);
		code_r0x80f9c97e:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,CONCAT44(in_register_20000014,puVar2[1]));
		    uVar3 = Core_Gameplay_Managers_WorldAxisManager__get_AttackPrice(uVar3,0);
		  }
		  else {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 600);
		          goto code_r0x80f9ca2f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x33);
		code_r0x80f9ca2f:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,CONCAT44(in_register_20000014,puVar2[1]));
		    uVar3 = Core_Gameplay_Managers_WorldAxisManager__set_Controller(uVar3,0);
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param1_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17790,1,0,1,0,0,0,0);
		  iVar5 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  uVar3 = Core_Extensions_Dict_ResourceSetExt__ToLocaleString(uVar3,NAN,0,StringLiteral_2556,0,0,0);
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_26152,uVar3,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar5 + 0x10) = local_8;
		  uVar3 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (param1_00,iVar5,0);
		  iVar5 = unnamed_function_1417(UI_ToolTip_ToolTipData_string__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (iVar5,0,Method_UI_ToolTip_ToolTipData_string___ctor__);
		  *(undefined4 *)(iVar5 + 0x1c) = uVar3;
		  return iVar5;
		}
		*/

			return null;
		}

		// Token: 0x06005162 RID: 20834 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005162")]
		[Address(RVA = "0x9F41", Offset = "0x9F41", VA = "0x9F41")]
		private BaseToolTipData GetAttackCostTooltip()
		{
		/* --- GHIDRA: GetAttackCostTooltip ---
		void Gameplay_Isles_Axis_View_ColossusInWorldView__GetAttackCostTooltip
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58d01 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_ColossusInWorldView_State___ctor__);
		    DAT_ram_00a58d01 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_ColossusInWorldView_State___ctor__);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005163 RID: 20835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005163")]
		[Address(RVA = "0x9F42", Offset = "0x9F42", VA = "0x9F42")]
		public ColossusInWorldView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Isles_Axis_View_ColossusInWorldView___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58d02 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Isles_Axis_View_ColossusInWorldView___c_TypeInfo);
		    DAT_ram_00a58d02 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Isles_Axis_View_ColossusInWorldView___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Isles_Axis_View_ColossusInWorldView___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04002C41 RID: 11329
		[Token(Token = "0x4002C41")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GameAssetViewSpriteRenderer _assetView;

		// Token: 0x04002C42 RID: 11330
		[Token(Token = "0x4002C42")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private WorldAxisScheduleView.SpriteByState[] _iconByState;

		// Token: 0x04002C43 RID: 11331
		[Token(Token = "0x4002C43")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private SpriteRenderer _stateIcon;

		// Token: 0x04002C44 RID: 11332
		[Token(Token = "0x4002C44")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BacktimeView _backtime;

		// Token: 0x04002C45 RID: 11333
		[Token(Token = "0x4002C45")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private ToolTipDelegate _shieldIconTooltip;

		// Token: 0x04002C46 RID: 11334
		[Token(Token = "0x4002C46")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ToolTipDelegate _actionIconTooltip;

		// Token: 0x04002C47 RID: 11335
		[Token(Token = "0x4002C47")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Button _button;

		// Token: 0x04002C48 RID: 11336
		[Token(Token = "0x4002C48")]
		[FieldOffset(Offset = "0x38")]
		private DelayedCall _shieldTimer;

		// Token: 0x04002C49 RID: 11337
		[Token(Token = "0x4002C49")]
		[FieldOffset(Offset = "0x3C")]
		private Dictionary<ColossusBattleData.State, Sprite> _swordsIconByStateDict;

		// Token: 0x02000D05 RID: 3333
		[Token(Token = "0x2000D05")]
		public enum State
		{
			// Token: 0x04002C4D RID: 11341
			[Token(Token = "0x4002C4D")]
			UNKNOWN_STATE,
			// Token: 0x04002C4E RID: 11342
			[Token(Token = "0x4002C4E")]
			ACTIVE,
			// Token: 0x04002C4F RID: 11343
			[Token(Token = "0x4002C4F")]
			DISABLED
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ShieldTimer ---
		int Gameplay_Isles_Axis_View_ColossusInWorldView__get_ShieldTimer(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 *puVar2;
		  int param1_01;
		  int param1_02;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58cf7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToDictionary_WorldAxisScheduleView_SpriteByState__ColossusBattleData_State__Sprite___
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_WorldAxisScheduleView_SpriteByState__ColossusBattleData_State__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Func_WorldAxisScheduleView_SpriteByState__Sprite__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Axis_View_ColossusInWorldView___c__get_SwordsIconByStateDict_b__13_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Axis_View_ColossusInWorldView___c__get_SwordsIconByStateDict_b__13_1__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Isles_Axis_View_ColossusInWorldView___c_TypeInfo);
		    DAT_ram_00a58cf7 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x3c);
		  if (iVar1 == 0) {
		    param1_00 = *(undefined4 *)(param1 + 0x20);
		    if (*(int *)(Gameplay_Isles_Axis_View_ColossusInWorldView___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Isles_Axis_View_ColossusInWorldView___c_TypeInfo);
		    }
		    puVar2 = *(undefined4 **)(Gameplay_Isles_Axis_View_ColossusInWorldView___c_TypeInfo + 0x5c);
		    param1_01 = puVar2[1];
		    iVar1 = Gameplay_Isles_Axis_View_ColossusInWorldView___c_TypeInfo;
		    if (param1_01 == 0) {
		      if (*(int *)(Gameplay_Isles_Axis_View_ColossusInWorldView___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_Isles_Axis_View_ColossusInWorldView___c_TypeInfo);
		        puVar2 = *(undefined4 **)(Gameplay_Isles_Axis_View_ColossusInWorldView___c_TypeInfo + 0x5c);
		      }
		      uVar3 = *puVar2;
		      param1_01 = unnamed_function_1417
		                            (
		                            System_Func_WorldAxisScheduleView_SpriteByState__ColossusBattleData_State__TypeInfo
		                            );
		      System_Action_object____ctor
		                (param1_01,uVar3,
		                 Method_Gameplay_Isles_Axis_View_ColossusInWorldView___c__get_SwordsIconByStateDict_b__13_0__
		                 ,0);
		      iVar1 = Gameplay_Isles_Axis_View_ColossusInWorldView___c_TypeInfo;
		      *(int *)(*(int *)(Gameplay_Isles_Axis_View_ColossusInWorldView___c_TypeInfo + 0x5c) + 4) =
		           param1_01;
		    }
		    if (*(int *)(iVar1 + 0x74) == 0) {
		      func_ii_306000(iVar1);
		      iVar1 = Gameplay_Isles_Axis_View_ColossusInWorldView___c_TypeInfo;
		    }
		    puVar2 = *(undefined4 **)(iVar1 + 0x5c);
		    param1_02 = puVar2[2];
		    if (param1_02 == 0) {
		      if (*(int *)(iVar1 + 0x74) == 0) {
		        func_ii_306000(iVar1);
		        puVar2 = *(undefined4 **)(Gameplay_Isles_Axis_View_ColossusInWorldView___c_TypeInfo + 0x5c);
		      }
		      uVar3 = *puVar2;
		      param1_02 = unnamed_function_1417
		                            (System_Func_WorldAxisScheduleView_SpriteByState__Sprite__TypeInfo);
		      System_Linq_Enumerable__Where_object_
		                (param1_02,uVar3,
		                 Method_Gameplay_Isles_Axis_View_ColossusInWorldView___c__get_SwordsIconByStateDict_b__13_1__
		                 ,0);
		      *(int *)(*(int *)(Gameplay_Isles_Axis_View_ColossusInWorldView___c_TypeInfo + 0x5c) + 8) =
		           param1_02;
		    }
		    iVar1 = System_Linq_Enumerable__ToDictionary_Int32Enum__Int32Enum__object_
		                      (param1_00,param1_01,param1_02,
		                       Method_System_Linq_Enumerable_ToDictionary_WorldAxisScheduleView_SpriteByState__ColossusBattleData_State__Sprite___
		                      );
		    *(int *)(param1 + 0x3c) = iVar1;
		  }
		  return iVar1;
		}
		*/


		/* --- GHIDRA: get_AssetViewSpriteRenderer ---
		void Gameplay_Isles_Axis_View_ColossusInWorldView__get_AssetViewSpriteRenderer
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58cf8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ColossusBattleData__TypeInfo);
		    DAT_ram_00a58cf8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x44);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ColossusBattleData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ColossusBattleData__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x44,iVar2,param1_00);
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


		/* --- GHIDRA: add_ClickedEvent ---
		void Gameplay_Isles_Axis_View_ColossusInWorldView__add_ClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58cf9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ColossusBattleData__TypeInfo);
		    DAT_ram_00a58cf9 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x44);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ColossusBattleData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ColossusBattleData__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x44,iVar2,param1_00);
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


		/* --- GHIDRA: remove_ClickedEvent ---
		void Gameplay_Isles_Axis_View_ColossusInWorldView__remove_ClickedEvent(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58cfa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameAssetViewSpriteRenderer__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_Axis_View_ColossusInWorldView_AssetViewClickedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_Axis_View_ColossusInWorldView_ButtonClickedEventHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a58cfa = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x1c);
		  uVar1 = unnamed_function_1417(System_Action_GameAssetViewSpriteRenderer__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Isles_Axis_View_ColossusInWorldView_AssetViewClickedEventHandler__,0);
		  AssetContent_GameAssetViewSpriteRenderer__get_SpriteRenderer(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x34) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Isles_Axis_View_ColossusInWorldView_ButtonClickedEventHandler__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  return;
		}
		*/

}
