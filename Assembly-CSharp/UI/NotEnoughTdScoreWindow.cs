using System;
using System.Runtime.CompilerServices;
using Gameplay.ThemeDuel.Model;
using Il2CppDummyDll;
using UI.Elements.Buttons;
using UI.Windows;
using UnityEngine;

namespace UI
{
	// Token: 0x02000107 RID: 263
	[Token(Token = "0x2000107")]
	public class NotEnoughTdScoreWindow : BaseDialogWindow<NotEnoughTdScoreWindow.NotEnoughTdScoreWindowArgs>
	{
		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x00003528 File Offset: 0x00001728
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700010F")]
		public bool PlayThemeDuelOnWindowClose
		{
			[Token(Token = "0x6000877")]
			[Address(RVA = "0x5C21", Offset = "0x5C21", VA = "0x5C21")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000878")]
			[Address(RVA = "0x5C22", Offset = "0x5C22", VA = "0x5C22")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000110")]
		public override string WindowId
		{
			[Token(Token = "0x6000879")]
			[Address(RVA = "0x5C23", Offset = "0x5C23", VA = "0x5C23", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600087A")]
		[Address(RVA = "0x5C24", Offset = "0x5C24", VA = "0x5C24", Slot = "27")]
		protected override void HandleDescription()
		{
		/* --- GHIDRA: HandleDescription ---
		void UI_NotEnoughTdScoreWindow__HandleDescription(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  float fVar4;
		  int *param1_00;
		  int iVar5;
		  undefined4 param2_00;
		  undefined4 param1_01;
		  int iVar6;
		  
		  if (DAT_ram_00a5b88d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_NotEnoughTdScoreWindow_NotEnoughTdScoreWindowArgs__OnShow__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a5b88d = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___OnDestroy
		            (param1,param2,
		             Method_UI_Windows_BaseDialogWindow_NotEnoughTdScoreWindow_NotEnoughTdScoreWindowArgs__OnShow__
		            );
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x1f8);
		        goto code_r0x8138ab65;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x8138ab65:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar6 = **(int **)(iVar5 + 0x14);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x100) * 4))
		                    (*(int **)(iVar5 + 0x14),*(undefined4 *)(iVar6 + 0x104));
		  uVar3 = Gameplay_Accounts_Model_Data_BattleAccount__GetPartyCombatCost
		                    (*(undefined4 *)(iVar5 + 0x28),*(undefined4 *)(*(int *)(param2 + 0x2c) + 0x14),0
		                    );
		  param2_00 = *(undefined4 *)(*(int *)(param2 + 0x2c) + 8);
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x50) + 0xb8);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar3 = Core_Money_Money__op_Explicit(uVar3,0);
		  UI_Price_Price__SetColor(param1_01,param2_00,uVar3,0);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x50),0);
		  iVar5 = Gameplay_ThemeDuelState_View_Balance_ThemeDuelBalanceView___ctor
		                    (*(undefined4 *)(*(int *)(param2 + 0x2c) + 0x14),0);
		  if (iVar5 == 0) {
		    uVar1 = 0;
		  }
		  else {
		    fVar4 = func_ii_7103(*(undefined4 *)(*(int *)(*(int *)(param2 + 0x2c) + 0x14) + 0x30),0);
		    uVar1 = (uint)(0.0 < fVar4);
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600087B")]
		[Address(RVA = "0x5C25", Offset = "0x5C25", VA = "0x5C25", Slot = "22")]
		protected override void OnShow(NotEnoughTdScoreWindow.NotEnoughTdScoreWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void UI_NotEnoughTdScoreWindow__OnShow(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5b88e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_NotEnoughTdScoreWindow_OnInDuel__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5b88e = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x50) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull(param1_00,param1,Method_UI_NotEnoughTdScoreWindow_OnInDuel__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600087C")]
		[Address(RVA = "0x5C26", Offset = "0x5C26", VA = "0x5C26")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void UI_NotEnoughTdScoreWindow__Start(int param1,undefined4 param2)
		
		{
		  *(undefined1 *)(param1 + 0x54) = 1;
		  System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew(param1,2,0);
		  return;
		}
		*/

		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600087D")]
		[Address(RVA = "0x5C27", Offset = "0x5C27", VA = "0x5C27")]
		private void OnInDuel()
		{
		/* --- GHIDRA: OnInDuel ---
		void UI_NotEnoughTdScoreWindow__OnInDuel(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5b88f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_NotEnoughTdScoreWindow_NotEnoughTdScoreWindowArgs__OnDestroy__
		              );
		    DAT_ram_00a5b88f = '\x01';
		  }
		  func_ii_14558(*(undefined4 *)(*(int *)(param1 + 0x50) + 0xb4),0);
		  UI_Windows_BaseDialogWindow_object___OnClose
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_NotEnoughTdScoreWindow_NotEnoughTdScoreWindowArgs__OnDestroy__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600087E")]
		[Address(RVA = "0x5C28", Offset = "0x5C28", VA = "0x5C28", Slot = "29")]
		protected override void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void UI_NotEnoughTdScoreWindow__OnDestroy(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5b890 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_NotEnoughTdScoreWindow_NotEnoughTdScoreWindowArgs___ctor__
		              );
		    DAT_ram_00a5b890 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_NotEnoughTdScoreWindow_NotEnoughTdScoreWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600087F")]
		[Address(RVA = "0x5C29", Offset = "0x5C29", VA = "0x5C29")]
		public NotEnoughTdScoreWindow()
		{
		}

		// Token: 0x04000305 RID: 773
		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ButtonWithCost _inDuelButton;

		// Token: 0x04000307 RID: 775
		[Token(Token = "0x4000307")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/NotEnoughTdScoreWindow";

		// Token: 0x02000108 RID: 264
		[Token(Token = "0x2000108")]
		public class NotEnoughTdScoreWindowArgs : BaseDialogWindow<NotEnoughTdScoreWindow.NotEnoughTdScoreWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x17000111 RID: 273
			// (get) Token: 0x06000880 RID: 2176 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000111")]
			public ThemeDuelModel Model
			{
				[Token(Token = "0x6000880")]
				[Address(RVA = "0x5C2A", Offset = "0x5C2A", VA = "0x5C2A")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17000112 RID: 274
			// (get) Token: 0x06000881 RID: 2177 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000112")]
			public string DescriptionShort
			{
				[Token(Token = "0x6000881")]
				[Address(RVA = "0x5C2B", Offset = "0x5C2B", VA = "0x5C2B")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06000882 RID: 2178 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000882")]
			[Address(RVA = "0x5C2C", Offset = "0x5C2C", VA = "0x5C2C")]
			public NotEnoughTdScoreWindowArgs(ThemeDuelModel model)
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_PlayThemeDuelOnWindowClose ---
		undefined4
		UI_NotEnoughTdScoreWindow__set_PlayThemeDuelOnWindowClose(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5b88b == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12655);
		    DAT_ram_00a5b88b = '\x01';
		  }
		  return StringLiteral_12655;
		}
		*/


		/* --- GHIDRA: get_WindowId ---
		void UI_NotEnoughTdScoreWindow__get_WindowId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  float fVar2;
		  int *piVar3;
		  undefined4 *puVar4;
		  
		  if (DAT_ram_00a5b88c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_NotEnoughTdScoreWindow_NotEnoughTdScoreWindowArgs__get_DescriptionField__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_NotEnoughTdScoreWindow_NotEnoughTdScoreWindowArgs__get_WindowArgs__
		              );
		    DAT_ram_00a5b88c = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 0x3c);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_NotEnoughTdScoreWindow_NotEnoughTdScoreWindowArgs__get_WindowArgs__
		                      );
		  iVar1 = Gameplay_ThemeDuelState_View_Balance_ThemeDuelBalanceView___ctor
		                    (*(undefined4 *)(*(int *)(iVar1 + 0x2c) + 0x14),0);
		  if (iVar1 != 0) {
		    iVar1 = func_ii_8093(param1,
		                         Method_UI_Windows_BaseWindow_NotEnoughTdScoreWindow_NotEnoughTdScoreWindowArgs__get_WindowArgs__
		                        );
		    fVar2 = func_ii_7103(*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x2c) + 0x14) + 0x30),0);
		    if (0.0 < fVar2) {
		      iVar1 = func_ii_8093(param1,
		                           Method_UI_Windows_BaseWindow_NotEnoughTdScoreWindow_NotEnoughTdScoreWindowArgs__get_WindowArgs__
		                          );
		      puVar4 = (undefined4 *)(iVar1 + 0x1c);
		      goto code_r0x8138aa71;
		    }
		  }
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_NotEnoughTdScoreWindow_NotEnoughTdScoreWindowArgs__get_WindowArgs__
		                      );
		  puVar4 = (undefined4 *)(iVar1 + 0x30);
		code_r0x8138aa71:
		  iVar1 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (piVar3,*puVar4,*(undefined4 *)(iVar1 + 0x2d4));
		  return;
		}
		*/

}
