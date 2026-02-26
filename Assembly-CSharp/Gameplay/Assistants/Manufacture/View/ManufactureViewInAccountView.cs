using System;
using System.Runtime.CompilerServices;
using Gameplay.Assistants.Manufacture.Control;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Elements.Counters;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Assistants.Manufacture.View
{
	// Token: 0x02000CAD RID: 3245
	[Token(Token = "0x2000CAD")]
	public class ManufactureViewInAccountView : MonoBehaviour, IDisposable
	{
		// Token: 0x17001005 RID: 4101
		// (get) Token: 0x06004EF2 RID: 20210 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001005")]
		public Transform BacktimeContainer
		{
			[Token(Token = "0x6004EF2")]
			[Address(RVA = "0x9D1A", Offset = "0x9D1A", VA = "0x9D1A")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001006 RID: 4102
		// (get) Token: 0x06004EF3 RID: 20211 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001006")]
		public TextMeshProUGUI BacktimeTitle
		{
			[Token(Token = "0x6004EF3")]
			[Address(RVA = "0x9D1B", Offset = "0x9D1B", VA = "0x9D1B")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001007 RID: 4103
		// (get) Token: 0x06004EF4 RID: 20212 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001007")]
		public BacktimeViewUGUI BacktimeView
		{
			[Token(Token = "0x6004EF4")]
			[Address(RVA = "0x9D1C", Offset = "0x9D1C", VA = "0x9D1C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001008 RID: 4104
		// (get) Token: 0x06004EF5 RID: 20213 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001008")]
		public Transform WarningWidget
		{
			[Token(Token = "0x6004EF5")]
			[Address(RVA = "0x9D1D", Offset = "0x9D1D", VA = "0x9D1D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001009 RID: 4105
		// (get) Token: 0x06004EF6 RID: 20214 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001009")]
		public TextMeshProUGUI Description
		{
			[Token(Token = "0x6004EF6")]
			[Address(RVA = "0x9D1E", Offset = "0x9D1E", VA = "0x9D1E")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700100A RID: 4106
		// (get) Token: 0x06004EF7 RID: 20215 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700100A")]
		public Button DisassembleAllButton
		{
			[Token(Token = "0x6004EF7")]
			[Address(RVA = "0x9D1F", Offset = "0x9D1F", VA = "0x9D1F")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700100B RID: 4107
		// (get) Token: 0x06004EF8 RID: 20216 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700100B")]
		public Button DisassemblePartButton
		{
			[Token(Token = "0x6004EF8")]
			[Address(RVA = "0x9D20", Offset = "0x9D20", VA = "0x9D20")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x06004EF9 RID: 20217 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700100C")]
		public MonoPointerClickHandler AddButton
		{
			[Token(Token = "0x6004EF9")]
			[Address(RVA = "0x9D21", Offset = "0x9D21", VA = "0x9D21")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700100D RID: 4109
		// (get) Token: 0x06004EFA RID: 20218 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700100D")]
		public ArtifactView ArtifactView
		{
			[Token(Token = "0x6004EFA")]
			[Address(RVA = "0x9D22", Offset = "0x9D22", VA = "0x9D22")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700100E RID: 4110
		// (get) Token: 0x06004EFB RID: 20219 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700100E")]
		public Button OpenRewardsButton
		{
			[Token(Token = "0x6004EFB")]
			[Address(RVA = "0x9D23", Offset = "0x9D23", VA = "0x9D23")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700100F RID: 4111
		// (get) Token: 0x06004EFC RID: 20220 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700100F")]
		public CounterAutoHide DropCounter
		{
			[Token(Token = "0x6004EFC")]
			[Address(RVA = "0x9D24", Offset = "0x9D24", VA = "0x9D24")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004EFD RID: 20221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EFD")]
		[Address(RVA = "0x9D25", Offset = "0x9D25", VA = "0x9D25")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Assistants_Manufacture_View_ManufactureViewInAccountView__OnDestroy
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x3c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x3c),*(undefined4 *)(iVar1 + 0x134));
		  *(undefined4 *)(param1 + 0x3c) = 0;
		  *(undefined4 *)(param1 + 0x44) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06004EFE RID: 20222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EFE")]
		[Address(RVA = "0x9D26", Offset = "0x9D26", VA = "0x9D26", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x17001010 RID: 4112
		// (get) Token: 0x06004EFF RID: 20223 RVA: 0x0000E850 File Offset: 0x0000CA50
		// (set) Token: 0x06004F00 RID: 20224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001010")]
		public bool IsInit
		{
			[Token(Token = "0x6004EFF")]
			[Address(RVA = "0x9D27", Offset = "0x9D27", VA = "0x9D27")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004F00")]
			[Address(RVA = "0x9D28", Offset = "0x9D28", VA = "0x9D28")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004F01 RID: 20225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F01")]
		[Address(RVA = "0x9D29", Offset = "0x9D29", VA = "0x9D29")]
		public void Init(ManufactureAssistant assistant)
		{
		}

		// Token: 0x17001011 RID: 4113
		// (get) Token: 0x06004F02 RID: 20226 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004F03 RID: 20227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001011")]
		public ManufactureAssistant Assistant
		{
			[Token(Token = "0x6004F02")]
			[Address(RVA = "0x9D2A", Offset = "0x9D2A", VA = "0x9D2A")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F03")]
			[Address(RVA = "0x9D2B", Offset = "0x9D2B", VA = "0x9D2B")]
			private set
			{
			}
		}

		// Token: 0x06004F04 RID: 20228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F04")]
		[Address(RVA = "0x9D2C", Offset = "0x9D2C", VA = "0x9D2C")]
		private void HandleAssistantChanged()
		{
		}

		// Token: 0x06004F05 RID: 20229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F05")]
		[Address(RVA = "0x9D2D", Offset = "0x9D2D", VA = "0x9D2D")]
		public ManufactureViewInAccountView()
		{
		}

		// Token: 0x04002B10 RID: 11024
		[Token(Token = "0x4002B10")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04002B11 RID: 11025
		[Token(Token = "0x4002B11")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Button _disassembleAllButton;

		// Token: 0x04002B12 RID: 11026
		[Token(Token = "0x4002B12")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _disassemblePartButton;

		// Token: 0x04002B13 RID: 11027
		[Token(Token = "0x4002B13")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private MonoPointerClickHandler _addButton;

		// Token: 0x04002B14 RID: 11028
		[Token(Token = "0x4002B14")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ArtifactView _artifactView;

		// Token: 0x04002B15 RID: 11029
		[Token(Token = "0x4002B15")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Button _openRewardsButton;

		// Token: 0x04002B16 RID: 11030
		[Token(Token = "0x4002B16")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _warningWidget;

		// Token: 0x04002B17 RID: 11031
		[Token(Token = "0x4002B17")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Transform _backtimeContainer;

		// Token: 0x04002B18 RID: 11032
		[Token(Token = "0x4002B18")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _backtimeTitle;

		// Token: 0x04002B19 RID: 11033
		[Token(Token = "0x4002B19")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x04002B1A RID: 11034
		[Token(Token = "0x4002B1A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CounterAutoHide _dropCont;

		// Token: 0x04002B1B RID: 11035
		[Token(Token = "0x4002B1B")]
		[FieldOffset(Offset = "0x3C")]
		private ManufactureAssistViewInAccountViewMediator _mediator;

		// Token: 0x04002B1D RID: 11037
		[Token(Token = "0x4002B1D")]
		[FieldOffset(Offset = "0x44")]
		private ManufactureAssistant _assistant;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_IsInit ---
		void Gameplay_Assistants_Manufacture_View_ManufactureViewInAccountView__set_IsInit
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (param2 != *(int *)(param1 + 0x44)) {
		    *(int *)(param1 + 0x44) = param2;
		    uVar1 = Gameplay_Assistants_Manufacture_ManufactureAssistant__Dispose(param2,param1,param1);
		    *(undefined4 *)(param1 + 0x3c) = uVar1;
		  }
		  *(undefined1 *)(param1 + 0x40) = 1;
		  return;
		}
		*/


		/* --- GHIDRA: get_Assistant ---
		void Gameplay_Assistants_Manufacture_View_ManufactureViewInAccountView__get_Assistant
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (param2 != *(int *)(param1 + 0x44)) {
		    *(int *)(param1 + 0x44) = param2;
		    uVar1 = Gameplay_Assistants_Manufacture_ManufactureAssistant__Dispose(param2,param1,param1);
		    *(undefined4 *)(param1 + 0x3c) = uVar1;
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Assistant ---
		void Gameplay_Assistants_Manufacture_View_ManufactureViewInAccountView__set_Assistant
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Gameplay_Assistants_Manufacture_ManufactureAssistant__Dispose
		                    (*(undefined4 *)(param1 + 0x44),param1,param1);
		  *(undefined4 *)(param1 + 0x3c) = uVar1;
		  return;
		}
		*/

}
