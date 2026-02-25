using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data.Balance;
using Core.Money;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Windows
{
	// Token: 0x02000261 RID: 609
	[Token(Token = "0x2000261")]
	[RequireComponent(typeof(DialogButtonsConfig))]
	public abstract class BaseDialogWindow<T> : WindowWhitCloseButton<T> where T : BaseDialogWindow<T>.BaseDialogWindowArgs
	{
		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000EAA RID: 3754 RVA: 0x000042A8 File Offset: 0x000024A8
		[Token(Token = "0x170001FD")]
		public override bool IsFullscreenWindow
		{
			[Token(Token = "0x6000EAA")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001FE")]
		private Button BgClickArea
		{
			[Token(Token = "0x6000EAB")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000EAC RID: 3756 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001FF")]
		public Transform Content
		{
			[Token(Token = "0x6000EAC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000EAD RID: 3757 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000200")]
		public TextMeshProUGUI DescriptionField
		{
			[Token(Token = "0x6000EAD")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EAE")]
		protected override void OnShow(T args)
		{
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EAF")]
		protected override void OnClose()
		{
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB0")]
		protected virtual void HandleTitle()
		{
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB1")]
		protected virtual void HandleDescription()
		{
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB2")]
		protected virtual void HandleContent()
		{
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB3")]
		private void HandleButtons()
		{
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB4")]
		private void DefaultButtonClick(Button button)
		{
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB5")]
		protected override void Awake()
		{
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB6")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB7")]
		protected BaseDialogWindow()
		{
		}

		// Token: 0x04000762 RID: 1890
		[Token(Token = "0x4000762")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private TextMeshProUGUI _titleField;

		// Token: 0x04000763 RID: 1891
		[Token(Token = "0x4000763")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private TextMeshProUGUI _descriptionField;

		// Token: 0x04000764 RID: 1892
		[Token(Token = "0x4000764")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Transform _content;

		// Token: 0x04000765 RID: 1893
		[Token(Token = "0x4000765")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Transform _buttonContent;

		// Token: 0x04000766 RID: 1894
		[Token(Token = "0x4000766")]
		[FieldOffset(Offset = "0x0")]
		private readonly List<Button> _currentButtons;

		// Token: 0x04000767 RID: 1895
		[Token(Token = "0x4000767")]
		[FieldOffset(Offset = "0x0")]
		private Button _bgClickArea;

		// Token: 0x02000262 RID: 610
		[Token(Token = "0x2000262")]
		public abstract class BaseDialogWindowArgs : BaseWindowArgs
		{
			// Token: 0x06000EB8 RID: 3768 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000EB8")]
			protected BaseDialogWindowArgs()
			{
			}

			// Token: 0x04000768 RID: 1896
			[Token(Token = "0x4000768")]
			[FieldOffset(Offset = "0x0")]
			public string Title;

			// Token: 0x04000769 RID: 1897
			[Token(Token = "0x4000769")]
			[FieldOffset(Offset = "0x0")]
			public string Description;

			// Token: 0x0400076A RID: 1898
			[Token(Token = "0x400076A")]
			[FieldOffset(Offset = "0x0")]
			public GameObject[] Content;

			// Token: 0x0400076B RID: 1899
			[Token(Token = "0x400076B")]
			[FieldOffset(Offset = "0x0")]
			public List<BaseDialogWindow<T>.BaseDialogWindowArgs.DialogWindowButton> Buttons;

			// Token: 0x0400076C RID: 1900
			[Token(Token = "0x400076C")]
			[FieldOffset(Offset = "0x0")]
			public bool ShowCloseButton;

			// Token: 0x02000263 RID: 611
			[Token(Token = "0x2000263")]
			public class DialogWindowButton
			{
				// Token: 0x06000EB9 RID: 3769 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000EB9")]
				public DialogWindowButton()
				{
				}

				// Token: 0x0400076D RID: 1901
				[Token(Token = "0x400076D")]
				[FieldOffset(Offset = "0x0")]
				public string Label;

				// Token: 0x0400076E RID: 1902
				[Token(Token = "0x400076E")]
				[FieldOffset(Offset = "0x0")]
				public DialogButtonsConfig.ButtonColors ColorOfButton;

				// Token: 0x0400076F RID: 1903
				[Token(Token = "0x400076F")]
				[FieldOffset(Offset = "0x0")]
				public BaseDialogWindow<T>.BaseDialogWindowArgs.DialogWindowButton.PriceHolder Price;

				// Token: 0x04000770 RID: 1904
				[Token(Token = "0x4000770")]
				[FieldOffset(Offset = "0x0")]
				public BaseDialogWindow<T>.BaseDialogWindowArgs.DialogWindowButton.ButtonInvoker ButtonCallback;

				// Token: 0x04000771 RID: 1905
				[Token(Token = "0x4000771")]
				[FieldOffset(Offset = "0x0")]
				public string GuideTargetId;

				// Token: 0x02000264 RID: 612
				[Token(Token = "0x2000264")]
				public class ButtonInvoker
				{
					// Token: 0x17000201 RID: 513
					// (get) Token: 0x06000EBA RID: 3770 RVA: 0x00002052 File Offset: 0x00000252
					// (set) Token: 0x06000EBB RID: 3771 RVA: 0x00002050 File Offset: 0x00000250
					[Token(Token = "0x17000201")]
					public BaseDialogWindow<T>.BaseDialogWindowArgs.DialogWindowButton.ButtonInvoker.ButtonCallbackDelegate Callback
					{
						[Token(Token = "0x6000EBA")]
						[CompilerGenerated]
						private get
						{
							return null;
						}
						[Token(Token = "0x6000EBB")]
						[CompilerGenerated]
						set
						{
						}
					}

					// Token: 0x06000EBC RID: 3772 RVA: 0x00002050 File Offset: 0x00000250
					[Token(Token = "0x6000EBC")]
					public virtual void Invoke(BaseDialogWindow<T> window)
					{
					}

					// Token: 0x06000EBD RID: 3773 RVA: 0x00002050 File Offset: 0x00000250
					[Token(Token = "0x6000EBD")]
					public ButtonInvoker()
					{
					}

					// Token: 0x02000265 RID: 613
					// (Invoke) Token: 0x06000EBF RID: 3775
					[Token(Token = "0x2000265")]
					public delegate void ButtonCallbackDelegate(BaseDialogWindow<T> window);
				}

				// Token: 0x02000266 RID: 614
				[Token(Token = "0x2000266")]
				public class ButtonInvoker<TData> : BaseDialogWindow<T>.BaseDialogWindowArgs.DialogWindowButton.ButtonInvoker
				{
					// Token: 0x06000EC2 RID: 3778 RVA: 0x00002050 File Offset: 0x00000250
					[Token(Token = "0x6000EC2")]
					public override void Invoke(BaseDialogWindow<T> window)
					{
					}

					// Token: 0x06000EC3 RID: 3779 RVA: 0x00002050 File Offset: 0x00000250
					[Token(Token = "0x6000EC3")]
					public ButtonInvoker()
					{
					}

					// Token: 0x04000773 RID: 1907
					[Token(Token = "0x4000773")]
					[FieldOffset(Offset = "0x0")]
					public TData Data;

					// Token: 0x04000774 RID: 1908
					[Token(Token = "0x4000774")]
					[FieldOffset(Offset = "0x0")]
					public BaseDialogWindow<T>.BaseDialogWindowArgs.DialogWindowButton.ButtonInvoker<TData>.ButtonCallbackDelegate Callback;

					// Token: 0x02000267 RID: 615
					// (Invoke) Token: 0x06000EC5 RID: 3781
					[Token(Token = "0x2000267")]
					public new delegate void ButtonCallbackDelegate(BaseDialogWindow<T> window, TData data);
				}

				// Token: 0x02000268 RID: 616
				[Token(Token = "0x2000268")]
				public class PriceHolder
				{
					// Token: 0x06000EC8 RID: 3784 RVA: 0x00002050 File Offset: 0x00000250
					[Token(Token = "0x6000EC8")]
					public PriceHolder()
					{
					}

					// Token: 0x04000775 RID: 1909
					[Token(Token = "0x4000775")]
					[FieldOffset(Offset = "0x0")]
					public Money Price;

					// Token: 0x04000776 RID: 1910
					[Token(Token = "0x4000776")]
					[FieldOffset(Offset = "0x0")]
					public IBalanceSource Balance;
				}
			}
		}
	}
}
